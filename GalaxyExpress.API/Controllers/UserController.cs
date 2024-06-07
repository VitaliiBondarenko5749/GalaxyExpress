using GalaxyExpress.BLL.DTOs.EmailDTOs;
using GalaxyExpress.BLL.DTOs.PhoneNumberDTOs;
using GalaxyExpress.BLL.DTOs.UserDTOs;
using GalaxyExpress.BLL.Extensions;
using GalaxyExpress.BLL.Services;
using GalaxyExpress.DAL.Entities;
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
    private readonly IDropboxService dropboxService;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="logger"></param>
    /// <param name="userService"></param>
    /// <param name="emailSenderService"></param>
    /// <param name="phoneNumberService"></param>
    /// <param name="dropboxService"></param>
    public UserController(ILogger<UserController> logger, IUserService userService, IEmailSenderService emailSenderService, 
        IPhoneNumberService phoneNumberService, IDropboxService dropboxService)
    {
        this.logger = logger;
        this.userService = userService;
        this.emailSenderService = emailSenderService;
        this.phoneNumberService = phoneNumberService;
        this.dropboxService = dropboxService;
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
                        Subject = "Підтвердження Email",
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

    /// <summary>
    /// Send Login value to activated phone numbers and Emails if you forgot it
    /// </summary>
    /// <param name="userId"></param>
    /// <returns>ServerResponse or StatusCode</returns>
    [HttpPost("ForgotLogin/{userId}")]
    public async Task<ActionResult<ServerResponse>> ForgotLoginAsync(Guid userId)
    {
        try
        {
            ServerResponse response = new();
            User? user = await userService.GetDataAsync(userId);

            if(user is null)
            {
                response.Message = $"Обліковий запис з AccountId: {userId} не знайдено";
                response.IsSuccess = false;

                return response;
            }

            UserEmailsAndPhoneNumbersDTO dto = await userService.GetEmailsAndPhoneNumbersAsync(userId);

            if (dto.Emails is not null)
            {
                string message = $"<p>Вітаємо <i>{user.FirstName}</i>,<br>" +
                    $"Ваш Login: <strong>{user.Login}</strong></p>";

                foreach (string email in dto.Emails)
                {
                    SendEmailDTO sendEmailDTO = new()
                    {
                        SendTo = email,
                        Subject = "Відновлення Login",
                        Message = message,
                        IsHtml = true
                    };

                    await emailSenderService.SendEmailAsync(sendEmailDTO);
                }
            }

            if (dto.PhoneNumbers is not null)
            {
                string message = $"Вітаємо {user.FirstName},\nВаш Login: {user.Login}";

                foreach (string phoneNumber in dto.PhoneNumbers)
                {
                    SendPhoneNumberMessageDTO sendPhoneNumberMessageDTO = new()
                    {
                        SendTo = phoneNumber,
                        Message = message
                    };

                    await phoneNumberService.SendMessageAsync(sendPhoneNumberMessageDTO);
                }
            }

            response.Message = "Значення login було відправленно на ваші активовані Email-адреси та номери телефонів!";
            response.IsSuccess = true;

            return response;
        }
        catch(Exception ex)
        {
            logger.LogError(ex.Message);
            return StatusCode(501, "INTERNAL SERVER ERROR");
        }
    }

    /// <summary>
    /// Forgot password method
    /// </summary>
    /// <param name="dto"></param>
    /// <returns>ServerResponse or StatusCode 501</returns>
    [HttpPost("ForgotPassword")]
    public async Task<ActionResult<ServerResponse>> ForgotPasswordAsync([FromForm] ForgotPasswordDTO dto)
    {
        try
        {
            ServerResponse response = await userService.ForgotPasswordAsync(dto);

            if (!response.IsSuccess)
            {
                return response;
            }

            SendEmailDTO sendEmailDto = new()
            {
                SendTo = dto.Email,
                Subject = "Відновлення паролю",
                Message = $"<p><i>Перейдіть за посиланням, для того щоб відновити пароль</i>: <a href={response.Message}>link</a></p>",
                IsHtml = true
            };

            await emailSenderService.SendEmailAsync(sendEmailDto);

            response.Message = "На вказаний Email було направлено лист з інструкцією відновлення вашого паролю.";

            return response;
        }
        catch(Exception ex)
        {
            logger.LogError(ex.Message);
            return StatusCode(501, "INTERNAL SERVER ERROR");
        }
    }

    /// <summary>
    /// Reset password method
    /// </summary>
    /// <param name="dto"></param>
    /// <returns>ServerResponse or StatusCode 501</returns>
    [HttpPost("ResetPassword")]
    public async Task<ActionResult<ServerResponse>> ResetPasswordAsync([FromForm] ResetPasswordDTO dto)
    {
        try
        {
            return await userService.ResetPasswordAsync(dto);
        }
        catch(Exception ex)
        {
            logger.LogError(ex.Message);
            return StatusCode(501, "INTERNAL SERVER ERROR");
        }
    }

    /// <summary>
    /// Update user
    /// </summary>
    /// <param name="dto"></param>
    /// <returns>ServerResponse or StatusCode 501</returns>
    [HttpPut]
    public async Task<ActionResult<ServerResponse>> UpdateAsync([FromForm] UpdateUserDTO dto)
    {
        try
        {
            if (dto.Photo is not null)
            {
                User? user = await userService.GetDataAsync(dto.UserId);

                if(user is null)
                {
                    return new ServerResponse { Message = "Користувача не знайдено!", IsSuccess = false };
                }

                if (!user.ImageDirectory.Equals("/UserIcons/Default-icon.png"))
                {
                    await dropboxService.DeleteFileAsync(user.ImageDirectory);
                }

                dto.Photo = await dropboxService.ChangeNameAsync(dto.Photo, $"{user.Id}-{dto.Photo.FileName}");
                string newImageDirectory = $"/UserIcons/{dto.Photo.FileName}";

                ServerResponse uploadResponse = await dropboxService.UploadFileAsync(dto.Photo.FileName, dto.Photo, "UserIcons");

                if (uploadResponse.IsSuccess) 
                {
                    user.ImageDirectory = newImageDirectory;
                    await userService.UpdateImageDirectoryAsync(user);
                }
            }

            ServerResponse response = await userService.UpdateAsync(dto);

            return response;
        }
        catch (Exception ex)
        {
            logger.LogError(ex.Message);
            return StatusCode(501, "INTERNAL SERVER ERROR");
        }
    }

    /// <summary>
    /// Delete user from database
    /// </summary>
    /// <param name="userId"></param>
    /// <returns></returns>
    [HttpDelete("{userId}")]
    public async Task<ActionResult<ServerResponse>> DeleteAsync(Guid userId)
    {
        try
        {
            ServerResponse response = await userService.DeleteAsync(userId);

            if(response.IsSuccess && response.Message is not null && !response.Message.Equals("/UserIcons/Default-icon.png"))
            {
                await dropboxService.DeleteFileAsync(response.Message);
                response.Message = "Користувача видалено!";
            }

            return response;
        }
        catch(Exception ex)
        {
            logger.LogError(ex.Message);
            return StatusCode(501, "INTERNAL SERVER ERROR");
        }
    }
}