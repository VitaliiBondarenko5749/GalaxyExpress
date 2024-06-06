using GalaxyExpress.BLL.DTOs.EmailDTOs;
using GalaxyExpress.BLL.DTOs.PhoneNumberDTOs;
using GalaxyExpress.BLL.Extensions;
using GalaxyExpress.BLL.Services;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;

namespace GalaxyExpress.API.Controllers;

/// <summary>
/// Email controller
/// </summary>
[Route("api/[controller]")]
[ApiController]
public class EmailController : ControllerBase
{
    private readonly ILogger<EmailController> logger;
    private readonly IEmailSenderService emailService;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="logger"></param>
    /// <param name="emailService"></param>
    public EmailController(ILogger<EmailController> logger, IEmailSenderService emailService)
    {
        this.logger = logger;
        this.emailService = emailService;
    }

    /// <summary>
    /// Send Email
    /// </summary>
    /// <param name="dto"></param>
    /// <returns>StatusCode 200 or 501</returns>
    [HttpPost]
    public async Task<IActionResult> SendEmailAsync([FromForm] SendEmailDTO dto)
    {
        try
        {
            await emailService.SendEmailAsync(dto);

            return Ok();
        }
        catch(Exception ex)
        {
            logger.LogError(ex.Message);
            return StatusCode(501, "INTERNAL SERVER ERROR");
        }
    }

    /// <summary>
    /// Check email existence
    /// </summary>
    /// <param name="userId"></param>
    /// <param name="email"></param>
    /// <returns>ServerResponse or StatusCode 501</returns>
    [HttpGet("CheckEmailExistence")]
    public async Task<ActionResult<ServerResponse>> CheckEmailExistenceAsync([FromQuery] Guid userId, [FromQuery] string email)
    {
        try
        {
            return await emailService.CheckEmailExistenceAsync(userId, email);
        }
        catch (Exception ex)
        {
            logger.LogError(ex.Message);
            return StatusCode(501, "INTERNAL SERVER ERROR");
        }
    }

    /// <summary>
    /// Add additional email
    /// </summary>
    /// <param name="dto"></param>
    /// <returns>ServerResponse or StatusCode 501</returns>
    [HttpPost("AddEmail")]
    public async Task<ActionResult<ServerResponse>> AddAsync([FromForm] AddEmailDTO dto)
    {
        try
        {
            ServerResponse response = await emailService.AddAsync(dto);

            if (response.IsSuccess)
            {
                string callbackUrl = $"http://localhost:3000/confirm-email/{response.Message}";

                SendEmailDTO sendEmailDTO = new()
                {
                    SendTo = dto.Email,
                    Subject = "Підтвердження додаткового Email",
                    Message = $"<p><strong>Підтвердіть свій додатковий Email натиснувши на посилання:</strong></p> <a href='{callbackUrl}'>link</a>",
                    IsHtml = true
                };

                await emailService.SendEmailAsync(sendEmailDTO);

                response.Message = $"Перейдіть на Email \'{dto.Email}\' для підтвердження!";
                response.IsSuccess = true;
                response.Errors = null;
            }

            return response;
        }
        catch(Exception ex)
        {
            logger.LogError(ex.Message);
            return StatusCode(501, "INTERNAL SERVER ERROR");
        }
    }

    /// <summary>
    /// Get emails by userId
    /// </summary>
    /// <param name="userId"></param>
    /// <returns>EmailInfoDTO[] or StatusCode501</returns>
    [HttpGet("{userId}")]
    public async Task<ActionResult<EmailInfoDTO[]>> GetAllByUserIdAsync(Guid userId)
    {
        try
        {
            return await emailService.GetAllByUserIdAsync(userId);
        }
        catch (Exception ex)
        {
            logger.LogError(ex.Message);
            return StatusCode(501, "INTERNAL SERVER ERROR");
        }
    }

    /// <summary>
    /// Delete email from user
    /// </summary>
    /// <param name="userId"></param>
    /// <param name="email"></param>
    /// <returns>ServerResponse or StatusCode 501</returns>
    [HttpDelete]
    public async Task<ActionResult<ServerResponse>> DeleteAsync([FromQuery] Guid userId, [FromQuery] string email)
    {
        try
        {
            return await emailService.DeleteAsync(userId, email);
        }
        catch(Exception ex)
        {
            logger.LogError(ex.Message);
            return StatusCode(501, "INTERNAL SERVER ERROR");
        }
    }
}