using GalaxyExpress.BLL.DTOs.PhoneNumberDTOs;
using Microsoft.Extensions.Configuration;

namespace GalaxyExpress.BLL.Services;

public interface IPhoneNumberService
{
    Task SendMessageAsync(SendPhoneNumberMessageDTO dto);
}

public class PhoneNumberService : IPhoneNumberService
{
    private readonly IConfiguration configuration;
    private readonly HttpClient httpClient;

    public PhoneNumberService(IConfiguration configuration, HttpClient httpClient)
    {
        this.configuration = configuration;
        this.httpClient = httpClient;
    }

    public async Task SendMessageAsync(SendPhoneNumberMessageDTO dto)
    {
        await httpClient.GetAsync($"https://platform.clickatell.com/messages/http/send?apiKey={configuration["CLICKATELL:Key"]}&to={dto.SendTo}&content={dto.Message}");
    }
}