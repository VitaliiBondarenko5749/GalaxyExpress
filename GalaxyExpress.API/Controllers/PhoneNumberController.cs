using GalaxyExpress.BLL.DTOs.PhoneNumberDTOs;
using GalaxyExpress.BLL.Extensions;
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

    /// <summary>
    /// Check phone number existence
    /// </summary>
    /// <param name="userId"></param>
    /// <param name="phoneNumber"></param>
    /// <returns>ServerResponse or StatusCode 501</returns>
    [HttpGet("CheckPhoneNumberExistence")]
    public async Task<ActionResult<ServerResponse>> CheckPhoneNumberExistenceAsync([FromQuery] Guid userId, 
        [FromQuery] string phoneNumber)
    {
        try
        {
            return await phoneNumberService.CheckPhoneNumberExistenceAsync(userId, phoneNumber);
        }
        catch (Exception ex)
        {
            logger.LogError(ex.Message);
            return StatusCode(501, "INTERNAL SERVER ERROR");
        }
    }

    /// <summary>
    /// Add new phone number to user
    /// </summary>
    /// <param name="dto"></param>
    /// <returns>ServerResponse or StatusCode 501</returns>
    [HttpPost("AddNumber")]
    public async Task<ActionResult<ServerResponse>> AddAsync([FromForm] AddPhoneNumberDTO dto)
    {
        try
        {
            return await phoneNumberService.AddAsync(dto);
        }
        catch(Exception ex)
        {
            logger.LogError(ex.Message);
            return StatusCode(501, "INTERNAL SERVER ERROR");
        }
    }

    /// <summary>
    /// Get phone numbers by userId
    /// </summary>
    /// <param name="userId"></param>
    /// <returns>PhoneNumberInfoDTO[] or StatusCode501</returns>
    [HttpGet("{userId}")]
    public async Task<ActionResult<PhoneNumberInfoDTO[]>> GetAllByUserIdAsync(Guid userId)
    {
        try
        {
            return await phoneNumberService.GetAllByUserIdAsync(userId);
        }
        catch(Exception ex)
        {
            logger.LogError(ex.Message);
            return StatusCode(501, "INTERNAL SERVER ERROR");
        }
    }

    /// <summary>
    /// Delete phone number from user
    /// </summary>
    /// <param name="userId"></param>
    /// <param name="phoneNumber"></param>
    /// <returns>ServerResponse or StatusCode 501</returns>
    [HttpDelete]
    public async Task<ActionResult<ServerResponse>> DeleteAsync([FromQuery] Guid userId, [FromQuery] string phoneNumber)
    {
        try
        {
            return await phoneNumberService.DeleteAsync(userId, phoneNumber);
        }
        catch (Exception ex)
        {
            logger.LogError(ex.Message);
            return StatusCode(501, "INTERNAL SERVER ERROR");
        }
    }
}