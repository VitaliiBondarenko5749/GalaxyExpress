using GalaxyExpress.BLL.DTOs.PhoneNumberDTOs;
using GalaxyExpress.BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace GalaxyExpress.API.Controllers;

/// <summary>
/// PhoneNumber controller
/// </summary>
[Route("api/[controller]")]
[ApiController]
public class PhoneNumberController : ControllerBase
{
    private readonly ILogger<PhoneNumberController> logger;
    private readonly IPhoneNumberService phoneNumberService;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="logger"></param>
    /// <param name="phoneNumberService"></param>
    public PhoneNumberController(ILogger<PhoneNumberController> logger, IPhoneNumberService phoneNumberService)
    {
        this.logger = logger;
        this.phoneNumberService = phoneNumberService;
    }

    /// <summary>
    /// Send message to phone number
    /// </summary>
    /// <param name="dto"></param>
    /// <returns>Status code 200 or 501</returns>
    [HttpPost]
    public async Task<IActionResult> SendMessageAsync([FromForm] SendPhoneNumberMessageDTO dto)
    {
        try
        {
            await phoneNumberService.SendMessageAsync(dto);

            return Ok();
        }
        catch(Exception ex)
        {
            logger.LogError(ex.Message);
            return StatusCode(501, "INTERNAL SERVER ERROR");
        }
    }
}