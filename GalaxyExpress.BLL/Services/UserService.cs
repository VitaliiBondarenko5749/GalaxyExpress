using FluentValidation.Results;
using GalaxyExpress.BLL.DTOs.UserDTOs;
using GalaxyExpress.BLL.Extensions;
using GalaxyExpress.BLL.Validators;
using GalaxyExpress.DAL.Entities;
using GalaxyExpress.DAL.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using NuGet.Protocol.Plugins;
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
    Task<UserEmailsAndPhoneNumbersDTO> GetEmailsAndPhoneNumbersAsync(Guid userId);
    Task<User?> GetDataAsync(Guid userId);
    Task<ServerResponse> ForgotPasswordAsync(ForgotPasswordDTO dto);
    Task<ServerResponse> ResetPasswordAsync(ResetPasswordDTO dto);
    Task<ServerResponse> UpdateAsync(UpdateUserDTO dto);
    Task UpdateImageDirectoryAsync(User user);
    Task<ServerResponse> DeleteAsync(Guid userId);
    Task<ServerResponse> ChangePasswordAsync(ChangePasswordDTO dto);
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
            ImageDirectory = "/UserIcons/Default-icon.png",
            BonusAccount = 20M,
            UserName = Guid.NewGuid().ToString(),
            ActivatedAccount = false
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

        if (userEmail is null || userEmail.EmailConfirmed)
        {
            return new ServerResponse
            {
                Message = "Помилка підтвердження токена!",
                IsSuccess = false
            };
        }

        string message = "Email підтверджено!";

        User user = await unitOfWork._userManager.Users.AsNoTracking()
                .SingleAsync(u => u.Id.Equals(userId));

        if (!user.ActivatedAccount)
        {
            user.ActivatedAccount = true;
            message = $"AccountId~{userEmail.UserId}";

            unitOfWork._dbContext.Attach(user);
            unitOfWork._dbContext.Entry(user).Property(u => u.ActivatedAccount).IsModified = true;

            await unitOfWork._userManager.UpdateAsync(user);
        }

        userEmail.EmailConfirmed = true;

        unitOfWork.Emails.UpdateAsync(userEmail);

        await unitOfWork.SaveChangesAsync();

        return new ServerResponse { Message = message, IsSuccess = true };
    }

    public async Task<int> GetCountOfUsers()
    {
        return await unitOfWork._userManager.Users.AsNoTracking()
            .Where(u => u.ActivatedAccount)
            .CountAsync();
    }

    public async Task<ServerResponse> LoginAsync(LoginUserDTO dto)
    {
        User? user = await unitOfWork._userManager.Users.AsNoTracking()
            .Include(u => u.Emails)
            .SingleOrDefaultAsync(u => u.Login.Equals(dto.Login));

        if (user is not null && await unitOfWork._userManager.CheckPasswordAsync(user, dto.Password) && user.ActivatedAccount)
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
            Message = (user is not null && !user.ActivatedAccount) ?
            "Ваш обліковий запис неактивований!" :
            "Помилка під час входу в акаунт!",
            IsSuccess = false
        };
    }

    public async Task<UserEmailsAndPhoneNumbersDTO> GetEmailsAndPhoneNumbersAsync(Guid userId)
    {
        UserEmailsAndPhoneNumbersDTO dto = new()
        {
            Emails = new List<string>(),
            PhoneNumbers = new List<string>(),
        };

        User? user = await unitOfWork._userManager.Users.AsNoTracking()
             .Include(u => u.Emails.Where(e => e.EmailConfirmed))
             .Include(u => u.PhoneNumbers)
             .SingleOrDefaultAsync(u => u.Id.Equals(userId));

        if(user is not null)
        {
            foreach (Email email in user.Emails)
            {
                dto.Emails.Add(email.EmailAddress);
            }

            foreach(PhoneNumber phoneNumber in user.PhoneNumbers)
            {
                dto.PhoneNumbers.Add(phoneNumber.Number.Substring(1));
            }
        }

        return dto;
    }

    public async Task<User?> GetDataAsync(Guid userId)
    {
        return await unitOfWork._userManager.Users.SingleOrDefaultAsync(u => u.Id.Equals(userId));
    }

    public async Task<ServerResponse> ForgotPasswordAsync(ForgotPasswordDTO dto)
    {
        Email? email = await unitOfWork.Emails.CheckUserEmailExistence(dto.Email, dto.UserId);

        if(email is null)
        {
            return new ServerResponse { Message = "Дані не знайдено!", IsSuccess = false };
        }

        User user = await unitOfWork._userManager.Users.AsNoTracking()
            .SingleAsync(u => u.Id.Equals(dto.UserId));

        string token = await unitOfWork._userManager.GeneratePasswordResetTokenAsync(user);
        string encodedToken = UrlEncoder.Encode(token);
        string callbackUrl = $"http://localhost:3000/reset-password?accountId={dto.UserId}&token={encodedToken}";

        return new ServerResponse { Message = callbackUrl, IsSuccess = true };
    }

    public async Task<ServerResponse> ResetPasswordAsync(ResetPasswordDTO dto)
    {
        ResetPasswordValidator validator = new();
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

        dto.Token = UrlEncoder.Decode(dto.Token);

        User? user = await unitOfWork._userManager.Users.SingleOrDefaultAsync(u => u.Id.Equals(dto.UserId));

        if (user is null)
        {
            return new ServerResponse { Message = "Користувача не знайдено!", IsSuccess = false };
        }

        IdentityResult identityResult = await unitOfWork._userManager.ResetPasswordAsync(user, dto.Token, dto.Password);

        await unitOfWork.SaveChangesAsync();

        return new ServerResponse
        {
            Message = (identityResult.Succeeded) ? "Пароль змінено!" : "Помилка під час зміни паролю!",
            IsSuccess = (identityResult.Succeeded) ? true : false,
            Errors = (identityResult.Succeeded) ? null : identityResult.Errors.Select(e => e.Description)
        };
    }

    public async Task<ServerResponse> UpdateAsync(UpdateUserDTO dto)
    {
        UpdateUserValidator validator = new();
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

        User? user = await unitOfWork._userManager.Users.SingleOrDefaultAsync(u => u.Id.Equals(dto.UserId));

        if (user is null)
        {
            return new ServerResponse { Message = "Користувача не знайдено!", IsSuccess = false };
        }

        string existedLogin = await unitOfWork._userManager.Users.AsNoTracking()
            .Where(u => u.Login.Equals(dto.Login))
            .Select(u => u.Login)
            .Take(1).SingleOrDefaultAsync() ?? string.Empty;

        if(!string.IsNullOrEmpty(existedLogin) && !existedLogin.Equals(user.Login))
        {
            return new ServerResponse { Message = $"Логін \"{existedLogin}\" вже зайнятий іншим користувачем!", IsSuccess = false };
        }

        user.Login = dto.Login;
        user.FirstName = dto.FirstName;
        user.LastName = dto.LastName;
        user.FatherName = dto.FatherName;
        user.Birthday = dto.Birthday;
        user.Sex = dto.Gender;

        await unitOfWork._userManager.UpdateAsync(user);

        await unitOfWork.SaveChangesAsync();

        List<Claim> claims = await GenerateClaims(user);
        string accessToken = CreateAccessToken(claims, 2);

        return new ServerResponse
        {
            Message = "Дані успішно оновлено!",
            IsSuccess = true,
            AccessToken = accessToken
        };
    }

    public async Task UpdateImageDirectoryAsync(User user)
    {
        await unitOfWork._userManager.UpdateAsync(user);

        await unitOfWork.SaveChangesAsync();

        await Task.Delay(1000);
    }

    public async Task<ServerResponse> ChangePasswordAsync(ChangePasswordDTO dto)
    {
        ChangePasswordValidator validator = new();
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

        User? user = await unitOfWork._userManager.Users.SingleOrDefaultAsync(u => u.Id.Equals(dto.UserId));

        if(user is null)
        {
            return new ServerResponse { Message = $"Користувач з accountId \"{dto.UserId}\" не існує!", IsSuccess = false };
        }

        IdentityResult identityResult = await unitOfWork._userManager.ChangePasswordAsync(user, dto.OldPassword, dto.NewPassword);

        if (identityResult.Succeeded)
        {
            return new ServerResponse { Message = "Пароль успішно змінено!", IsSuccess = true };
        }

        return new ServerResponse
        {
            Message = "Помилка при зміні паролю! Всі помилки в \"Errors\" списку!",
            IsSuccess = false,
            Errors = identityResult.Errors.Select(e => e.Description)
        };
    }

    public async Task<ServerResponse> DeleteAsync(Guid userId)
    {
        User? user = await unitOfWork._userManager.Users
            .SingleOrDefaultAsync(u => u.Id.Equals(userId));

        if(user is null)
        {
            return new ServerResponse { Message = "Користувача не знайдено!", IsSuccess = false };
        }

        await unitOfWork._userManager.DeleteAsync(user);

        await unitOfWork.SaveChangesAsync();

        return new ServerResponse { Message = user.ImageDirectory, IsSuccess = true };
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

        foreach (string role in roles)
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