using GalaxyExpress.BLL.DTOs.EmailDTOs;
using MimeKit.Text;
using MimeKit;
using MailKit.Net.Smtp;
using GalaxyExpress.BLL.Extensions;
using GalaxyExpress.DAL.Repositories;
using GalaxyExpress.DAL.Entities;
using GalaxyExpress.BLL.Validators;
using FluentValidation.Results;
using Bogus.DataSets;
using AutoMapper;

namespace GalaxyExpress.BLL.Services;

public interface IEmailSenderService
{
    Task SendEmailAsync(SendEmailDTO dto);
    Task<ServerResponse> CheckEmailExistenceAsync(Guid userId, string email);
    Task<ServerResponse> AddAsync(AddEmailDTO dto);
    Task<EmailInfoDTO[]> GetAllByUserIdAsync(Guid userId);
    Task<ServerResponse> DeleteAsync(Guid userId, string email);
}

public class EmailSenderService : IEmailSenderService
{
    private readonly IUnitOfWork unitOfWork;

    public EmailSenderService(IUnitOfWork unitOfWork)
    {
        this.unitOfWork = unitOfWork;
    }

    public async Task SendEmailAsync(SendEmailDTO dto)
    {
        using MimeMessage emailMessage = new();

        emailMessage.From.Add(new MailboxAddress("GalaxyExpress", "galaxyexpress7438@gmail.com"));
        emailMessage.To.Add(new MailboxAddress(string.Empty, dto.SendTo));
        emailMessage.Subject = dto.Subject; // It's a title.
        emailMessage.Body = new TextPart((dto.IsHtml) ? TextFormat.Html : TextFormat.Text)
        {
            Text = dto.Message
        };

        using (SmtpClient client = new())
        {
            await client.ConnectAsync("smtp.gmail.com", 465, true);
            await client.AuthenticateAsync("galaxyexpress7438@gmail.com", "zoxu nwcj yole imci");
            await client.SendAsync(emailMessage);

            await client.DisconnectAsync(true);
        }
    }

    public async Task<ServerResponse> CheckEmailExistenceAsync(Guid userId, string email)
    {
        Email? userEmail = await unitOfWork.Emails.CheckUserEmailExistence(email, userId);

        return new ServerResponse
        {
            Message = (userEmail is not null) ? "Email присутній у користувача" : "Email неприсутній у користувача",
            IsSuccess = (userEmail is not null) ? true : false
        };
    }

    public async Task<ServerResponse> AddAsync(AddEmailDTO dto)
    {
        AddEmailValidator validator = new();
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

        Email? email = await unitOfWork.Emails.CheckUserEmailExistence(dto.Email, dto.UserId);

        if (email is not null)
        {
            return new ServerResponse { Message = "Email вже присутній у користувача!", IsSuccess = false };
        }

        email = new()
        {
            EmailId = Guid.NewGuid(),
            UserId = dto.UserId,
            EmailAddress = dto.Email,
            EmailConfirmed = false
        };

        await unitOfWork.Emails.CreateAsync(email);

        await unitOfWork.SaveChangesAsync();

        return new ServerResponse { Message = UrlEncoder.Encode($"{dto.Email}~{dto.UserId}"), IsSuccess = true };
    }

    public async Task<EmailInfoDTO[]> GetAllByUserIdAsync(Guid userId)
    {
        Email[] emails = await unitOfWork.Emails.GetAllByUserIdAsync(userId);

        return MapperConfiguration.CreateMapper()
            .Map<EmailInfoDTO[]>(emails);
    }

    public async Task<ServerResponse> DeleteAsync(Guid userId, string email)
    {
        Email? userEmail = await unitOfWork.Emails.CheckUserEmailExistence(email, userId);

        if(userEmail is null)
        {
            return new ServerResponse { Message = "Немає таких даний!", IsSuccess = false };
        }

        Email[] emails = await unitOfWork.Emails.GetAllByUserIdAsync(userId);

        if (emails.Length <= 1)
        {
            return new ServerResponse { Message = "Користувач обов'язково повинен мати мінімум 1 Email!", IsSuccess = false };
        }

        await unitOfWork.Emails.DeleteAsync(userEmail.EmailId);

        await unitOfWork.SaveChangesAsync();

        return new ServerResponse { Message = "Дані успішно видалено!", IsSuccess = true };
    }

    private static MapperConfiguration MapperConfiguration
    {
        get => new(config =>
        {
            config.CreateMap<Email, EmailInfoDTO>();
        });
    }
}