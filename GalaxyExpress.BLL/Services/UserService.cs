using FluentValidation.Results;
using GalaxyExpress.BLL.DTOs.UserDTOs;
using GalaxyExpress.BLL.Extensions;
using GalaxyExpress.BLL.Validators;
using GalaxyExpress.DAL.Entities;
using GalaxyExpress.DAL.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace GalaxyExpress.BLL.Services;

public interface IUserService
{
    Task<ServerResponse> RegisterAsync(RegisterUserDTO dto);
    Task<ServerResponse> CheckLoginExistenceAsync(string login);
    Task<ServerResponse> ConfirmEmailAsync(string token);
}

public class UserService : IUserService
{
    private readonly IUnitOfWork unitOfWork;

    public UserService(IUnitOfWork unitOfWork)
    {
        this.unitOfWork = unitOfWork;
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
}