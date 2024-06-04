using GalaxyExpress.BLL.DTOs.EmailDTOs;
using GalaxyExpress.BLL.Services;
using Microsoft.AspNetCore.Mvc;

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
}