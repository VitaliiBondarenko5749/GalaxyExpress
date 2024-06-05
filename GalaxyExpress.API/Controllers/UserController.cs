using GalaxyExpress.BLL.DTOs.EmailDTOs;
using GalaxyExpress.BLL.DTOs.PhoneNumberDTOs;
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
    private readonly IPhoneNumberService phoneNumberService;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="logger"></param>
    /// <param name="userService"></param>
    /// <param name="emailSenderService"></param>
    /// <param name="phoneNumberService"></param>
    public UserController(ILogger<UserController> logger, IUserService userService, IEmailSenderService emailSenderService, 
        IPhoneNumberService phoneNumberService)
    {
        this.logger = logger;
        this.userService = userService;
        this.emailSenderService = emailSenderService;
        this.phoneNumberService = phoneNumberService;
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
            ServerResponse response = await userService.ConfirmEmailAsync(token);

            if (response.Message is not null && response.Message.Contains("AccountId~"))
            {
                Guid userId = Guid.Parse(response.Message.Substring(response.Message.IndexOf('~') + 1));
                UserEmailsAndPhoneNumbersDTO dto = await userService.GetEmailsAndPhoneNumbersAsync(userId);

                if(dto.Emails is not null)
                {
                    string message = "<p>Вітаємо! Ви стали частиною платформи \'Galaxy Express\'!<br>" +
                        $"Ваш AccountId (потрібен для відновлення облікового запису): <strong>{userId}</strong></p>";

                    foreach(string email in dto.Emails)
                    {
                        SendEmailDTO sendEmailDTO = new()
                        {
                            SendTo = email,
                            Subject = "Вітаємо на платформі \'Galaxy Express\'",
                            Message = message,
                            IsHtml = true
                        };

                        await emailSenderService.SendEmailAsync(sendEmailDTO);
                    } 
                }

                if(dto.PhoneNumbers is not null)
                {
                    string message = "Вітаємо! Ви стали частиною платформи 'Galaxy Express'!\n" +
                        $"Ваш AccountId (потрібен для відновлення облікового запису): {userId}";

                    foreach(string phoneNumber in dto.PhoneNumbers)
                    {
                        SendPhoneNumberMessageDTO sendPhoneNumberMessageDTO = new()
                        {
                            SendTo = phoneNumber,
                            Message = message
                        };

                        await phoneNumberService.SendMessageAsync(sendPhoneNumberMessageDTO);
                    }
                }

                response.Message = "Email підтверджено!";
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
    /// Check login existence
    /// </summary>
    /// <param name="login"></param>
    /// <returns>Server Response</returns>
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

    /// <summary>
    /// Returns count of users that any email is confirmed
    /// </summary>
    /// <returns>int or Status code 501</returns>
    [HttpGet("GetCountOfUsers")]
    public async Task<ActionResult<int>> GetCountOfUsersAsync()
    {
        try
        {
            return await userService.GetCountOfUsers();
        }
        catch(Exception ex)
        {
            logger.LogError(ex.Message);
            return StatusCode(501, "INTERNAL SERVER ERROR");
        }
    }

    /// <summary>
    /// Login User
    /// </summary>
    /// <param name="dto"></param>
    /// <returns>ServerResponse</returns>
    [HttpPost("Login")]
    public async Task<ActionResult<ServerResponse>> LoginAsync([FromForm] LoginUserDTO dto)
    {
        try
        {
            return await userService.LoginAsync(dto);
        }
        catch(Exception ex)
        {
            logger.LogError(ex.Message);
            return StatusCode(501, "INTERNAL SERVER ERROR");
        }
    }
}