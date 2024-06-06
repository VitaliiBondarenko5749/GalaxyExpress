using AutoMapper;
using FluentValidation.Results;
using GalaxyExpress.BLL.DTOs.PhoneNumberDTOs;
using GalaxyExpress.BLL.Extensions;
using GalaxyExpress.BLL.Validators;
using GalaxyExpress.DAL.Entities;
using GalaxyExpress.DAL.Repositories;
using Microsoft.Extensions.Configuration;

namespace GalaxyExpress.BLL.Services;

public interface IPhoneNumberService
{
    Task SendMessageAsync(SendPhoneNumberMessageDTO dto);
    Task<ServerResponse> CheckPhoneNumberExistenceAsync(Guid userId, string phoneNumber);
    Task<ServerResponse> AddAsync(AddPhoneNumberDTO dto);
    Task<PhoneNumberInfoDTO[]> GetAllByUserIdAsync(Guid userId);
    Task<ServerResponse> DeleteAsync(Guid userId, string phoneNumber);
}

public class PhoneNumberService : IPhoneNumberService
{
    private readonly IConfiguration configuration;
    private readonly HttpClient httpClient;
    private readonly IUnitOfWork unitOfWork;

    public PhoneNumberService(IConfiguration configuration, HttpClient httpClient, IUnitOfWork unitOfWork)
    {
        this.configuration = configuration;
        this.httpClient = httpClient;
        this.unitOfWork = unitOfWork;
    }

    public async Task SendMessageAsync(SendPhoneNumberMessageDTO dto)
    {
        await httpClient.GetAsync($"https://platform.clickatell.com/messages/http/send?apiKey={configuration["CLICKATELL:Key"]}&to={dto.SendTo}&content={dto.Message}");
    }

    public async Task<ServerResponse> CheckPhoneNumberExistenceAsync(Guid userId, string phoneNumber)
    {
        PhoneNumber? number = await unitOfWork.PhoneNumbers.CheckUserPhoneNumberExistenceAsync(userId, phoneNumber);

        return new ServerResponse
        {
            Message = (number is not null) ? "Номер присутній у користувача" : "Номер неприсутній у користувача!",
            IsSuccess = (number is not null) ? true : false
        };
    }

    public async Task<ServerResponse> AddAsync(AddPhoneNumberDTO dto)
    {
        AddPhoneNumberValidator validator = new();
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

        PhoneNumber? phoneNumber = await unitOfWork.PhoneNumbers.CheckUserPhoneNumberExistenceAsync(dto.UserId, dto.PhoneNumber);

        if (phoneNumber is not null)
        {
            return new ServerResponse { Message = "Номер телефону вже присутній у користувача!", IsSuccess = false };
        }

        phoneNumber = new()
        {
            PhoneNumberId = Guid.NewGuid(),
            UserId = dto.UserId,
            Number = dto.PhoneNumber
        };

        await unitOfWork.PhoneNumbers.CreateAsync(phoneNumber);

        await unitOfWork.SaveChangesAsync();

        return new ServerResponse
        {
            Message = "Номер додано!",
            IsSuccess = true
        };
    }

    public async Task<PhoneNumberInfoDTO[]> GetAllByUserIdAsync(Guid userId)
    {
        PhoneNumber[] phoneNumbers = await unitOfWork.PhoneNumbers.GetAllByUserIdAsync(userId);

        return MapperConfiguration.CreateMapper()
            .Map<PhoneNumberInfoDTO[]>(phoneNumbers);
    }

    public async Task<ServerResponse> DeleteAsync(Guid userId, string phoneNumber)
    {
        PhoneNumber? number = await unitOfWork.PhoneNumbers.CheckUserPhoneNumberExistenceAsync(userId, phoneNumber);

        if (number is null)
        {
            return new ServerResponse { Message = "Немає такого номеру!", IsSuccess = false };
        }

        PhoneNumber[] numbers = await unitOfWork.PhoneNumbers.GetAllByUserIdAsync(userId);

        if(numbers.Length <= 1)
        {
            return new ServerResponse { Message = "Користувач обов'язково повинен мати мінімум 1 номер!", IsSuccess = false };
        }

        await unitOfWork.PhoneNumbers.DeleteAsync(number.PhoneNumberId);

        await unitOfWork.SaveChangesAsync();

        return new ServerResponse { Message = "Дані успішно видалено!", IsSuccess = true };
    }

    private static MapperConfiguration MapperConfiguration
    {
        get => new(config =>
        {
            config.CreateMap<PhoneNumber, PhoneNumberInfoDTO>();
        });
    }
}