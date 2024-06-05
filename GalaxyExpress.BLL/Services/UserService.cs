﻿using FluentValidation.Results;
using GalaxyExpress.BLL.DTOs.UserDTOs;
using GalaxyExpress.BLL.Extensions;
using GalaxyExpress.BLL.Validators;
using GalaxyExpress.DAL.Entities;
using GalaxyExpress.DAL.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace GalaxyExpress.BLL.Services;

public interface IUserService
{
    Task<ServerResponse> RegisterAsync(RegisterUserDTO dto);
    Task<ServerResponse> CheckLoginExistenceAsync(string login);
    Task<ServerResponse> ConfirmEmailAsync(string token);
    Task<int> GetCountOfUsers();
    Task<ServerResponse> LoginAsync(LoginUserDTO dto);
}

public class UserService : IUserService
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IConfiguration configuration;

    public UserService(IUnitOfWork unitOfWork, IConfiguration configuration)
    {
        this.unitOfWork = unitOfWork;
        this.configuration = configuration;
    }

    public async Task<ServerResponse> RegisterAsync(RegisterUserDTO dto)
    {
        RegisterUserValidator validator = new();
        ValidationResult validationResult = await validator.ValidateAsync(dto);

        if (!validationResult.IsValid)
        {
            string errors = validationResult.ToString("~");

            return new ServerResponse
            {
                Message = "Щось пішло не так... всі помилки в списку \"Errors\"!",
                IsSuccess = false,
                Errors = errors.Split('~')
            };
        }

        // TODO: Change image directory path
        User user = new()
        {
            Id = Guid.NewGuid(),
            DateCreated = DateTime.Now,
            Login = dto.Login,
            FirstName = dto.FirstName,
            LastName = dto.LastName,
            FatherName = dto.FatherName,
            Birthday = null,
            Sex = Gender.NotSelected,
            ImageDirectory = null,
            BonusAccount = 20M,
            UserName = Guid.NewGuid().ToString(),
        };

        IdentityResult identityResult = await unitOfWork._userManager.CreateAsync(user, dto.Password);

        if (identityResult.Succeeded)
        {
            Email email = new()
            {
                EmailId = Guid.NewGuid(),
                EmailAddress = dto.Email,
                EmailConfirmed = false,
                UserId = user.Id
            };

            PhoneNumber phoneNumber = new()
            {
                PhoneNumberId = Guid.NewGuid(),
                Number = dto.PhoneNumber,
                PhoneNumberConfirmed = true,
                UserId = user.Id
            };

            await unitOfWork.Emails.CreateAsync(email);

            await unitOfWork.PhoneNumbers.CreateAsync(phoneNumber);

            await unitOfWork.SaveChangesAsync();

            return new ServerResponse { Message = UrlEncoder.Encode($"{email.EmailAddress}~{user.Id}"), IsSuccess = true };
        }

        return new ServerResponse 
        { 
            Message = "Щось пішло не так... всі помилки в списку \"Errors\"!",
            Errors = identityResult.Errors.Select(e => e.Description),
            IsSuccess = false
        };
    }

    public async Task<ServerResponse> CheckLoginExistenceAsync(string login)
    {
        User? user = await unitOfWork._userManager.Users.AsNoTracking()
            .SingleOrDefaultAsync(u => u.Login.Equals(login));

        return new ServerResponse
        {
            Message = (user is not null) ? $"Логін \"{login}\" використовується іншим користувачем!"
            : $"Логін \"{login}\" можна використовувати",
            IsSuccess = (user is not null) ? true : false
        };
    }

    public async Task<ServerResponse> ConfirmEmailAsync(string token)
    {
        string decodedToken = UrlEncoder.Decode(token);
        string[] userData = decodedToken.Split('~');
        string email = userData[0];
        Guid userId = Guid.Parse(userData[1]);

        Email? userEmail = await unitOfWork.Emails.CheckUserEmailExistence(email, userId);
        
        if(userEmail is null || userEmail.EmailConfirmed)
        {
            return new ServerResponse
            {
                Message = "Помилка підтвердження токена!",
                IsSuccess = false
            };
        }

        userEmail.EmailConfirmed = true;

        await unitOfWork.Emails.UpdateAsync(userEmail);

        await unitOfWork.SaveChangesAsync();

        return new ServerResponse { Message = "Email підтверджено!", IsSuccess = true };
    }

    public async Task<int> GetCountOfUsers()
    {
        return await unitOfWork._userManager.Users.AsNoTracking()
            .Where(u => u.Emails.Any(e => e.EmailConfirmed))
            .CountAsync();
    }

    public async Task<ServerResponse> LoginAsync(LoginUserDTO dto)
    {
        User? user = await unitOfWork._userManager.Users.AsNoTracking()
            .Include(u => u.Emails)
            .SingleOrDefaultAsync(u => u.Login.Equals(dto.Login));

        if(user is not null && await unitOfWork._userManager.CheckPasswordAsync(user, dto.Password))
        {
            List<Claim> claims = await GenerateClaims(user);
            string accessToken = CreateAccessToken(claims, 2);

            return new ServerResponse()
            {
                Message = $"Ласкаво просимо {user.Login}!",
                AccessToken = accessToken,
                IsSuccess = true
            };
        }

        return new ServerResponse
        {
            Message = (user is not null && !user.Emails.Any(e => e.EmailConfirmed)) ?
            "Підтвердіть хоча б один Email для того щоб користуватися акаунтом!" :
            "Помилка під час входу в акаунт!",
            IsSuccess = false
        };
    }

    private async Task<List<Claim>> GenerateClaims(User user)
    {
        List<Claim> claims = new()
        {
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new Claim("DateCreated", $"{user.DateCreated.Day}.{user.DateCreated.Month}.{user.DateCreated.Year}"),
            new Claim("Login", user.Login),
            new Claim("FirstName", user.FirstName),
            new Claim("LastName", user.LastName),
            new Claim("FatherName", user.FatherName ?? string.Empty),
            new Claim("Birthday", (user.Birthday.HasValue) ? $"{user.Birthday.Value.Day}.{user.Birthday.Value.Month}.{user.Birthday.Value.Year}" 
            : string.Empty),
            new Claim("ImageDirectory", user.ImageDirectory ?? string.Empty),
            new Claim("Gender", user.Sex.ToString()),
            new Claim("BonusAccount", user.BonusAccount.ToString())
        };

        IList<string> roles = await unitOfWork._userManager.GetRolesAsync(user);

        foreach(string role in roles)
        {
            claims.Add(new Claim("Role", role));
        }

        return claims;
    }

    private string CreateAccessToken(List<Claim> claims, int tokenValidityInHours) // DONE. 
    {
        SymmetricSecurityKey signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Key"]));

        JwtSecurityToken token = new JwtSecurityToken(
            issuer: configuration["JWT:ValidIssuer"],
            audience: configuration["JWT:ValidAudience"],
            expires: DateTime.Now.AddHours(tokenValidityInHours),
            claims: claims,
            signingCredentials: new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256)
            );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}