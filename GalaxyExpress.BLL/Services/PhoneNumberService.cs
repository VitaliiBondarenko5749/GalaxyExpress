using GalaxyExpress.BLL.DTOs.PhoneNumberDTOs;
using GalaxyExpress.BLL.Extensions;
using GalaxyExpress.DAL.Entities;
using GalaxyExpress.DAL.Repositories;
using Microsoft.Extensions.Configuration;

namespace GalaxyExpress.BLL.Services;

public interface IPhoneNumberService
{
    Task SendMessageAsync(SendPhoneNumberMessageDTO dto);
    Task<ServerResponse> CheckPhoneNumberExistenceAsync(Guid userId, string phoneNumber);
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
}