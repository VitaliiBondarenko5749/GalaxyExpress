using GalaxyExpress.BLL.DTOs.EmailDTOs;
using GalaxyExpress.BLL.DTOs.UserDTOs;
using GalaxyExpress.BLL.Extensions;
using GalaxyExpress.BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace GalaxyExpress.API.Controllers;

/// <summary>
/// User controller
/// </summary>
[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly ILogger<UserController> logger;
    private readonly IUserService userService;
    private readonly IEmailSenderService emailSenderService;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="logger"></param>
    /// <param name="userService"></param>
    /// <param name="emailSenderService"></param>
    public UserController(ILogger<UserController> logger, IUserService userService, IEmailSenderService emailSenderService)
    {
        this.logger = logger;
        this.userService = userService;
        this.emailSenderService = emailSenderService;
    }

    /// <summary>
    /// Register a new user
    /// </summary>
    /// <param name="dto"></param>
    /// <returns>Server Response</returns>
    [HttpPost]
    public async Task<ActionResult<ServerResponse>> RegisterAsync([FromForm] RegisterUserDTO dto)
    {
        try
        {
            ServerResponse response = await userService.CheckLoginExistenceAsync(dto.Login);

            if (!response.IsSuccess)
            {
                response = await userService.RegisterAsync(dto);

                if (response.IsSuccess)
                {
                    string callbackUrl = $"http://localhost:3000/confirm-email/{response.Message}";

                    SendEmailDTO sendEmailDTO = new()
                    {
                        SendTo = dto.Email,
                        Subject = "Confirm Email",
                        Message = $"<p><strong>Підтвердіть свій Email для користування акаунтом натиснувши на посилання:</strong></p> <a href='{callbackUrl}'>link</a>",
                        IsHtml = true
                    };

                    await emailSenderService.SendEmailAsync(sendEmailDTO);

                    response.Message = $"Перейдіть на Email \'{dto.Email}\' та підтвердіть свою реєстрацію!";
                    response.IsSuccess = true;
                    response.Errors = null;
                }
            }

            return response;
        }
        catch (Exception ex)
        {
            logger.LogError(ex.Message);
            return StatusCode(501, "INTERNAL SERVER ERROR");
        }
    }

    /// <summary>
    /// Confirm user email
    /// </summary>
    /// <param name="token"></param>
    /// <returns>ServerResponse</returns>
    [HttpGet("ConfirmEmail/{token}")]
    public async Task<ActionResult<ServerResponse>> ConfirmEmailAsync(string token)
    {
        try
        {
            return await userService.ConfirmEmailAsync(token);
        }
        catch(Exception ex)
        {
            logger.LogError(ex.Message);
            return StatusCode(501, "INTERNAL SERVER ERROR");
        }
    }

    [HttpGet("CheckLoginExistence/{login}")]
    public async Task<ActionResult<ServerResponse>> CheckLoginExistenceAsync(string login)
    {
        try
        {
            return await userService.CheckLoginExistenceAsync(login);
        }
        catch(Exception ex)
        {
            logger.LogError(ex.Message);
            return StatusCode(501, "INTERNAL SERVER ERROR");
        }
    }
}