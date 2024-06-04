using GalaxyExpress.BLL.DTOs.EmailDTOs;
using MimeKit.Text;
using MimeKit;
using MailKit.Net.Smtp;

namespace GalaxyExpress.BLL.Services;

public interface IEmailSenderService
{
    Task SendEmailAsync(SendEmailDTO dto);
}

public class EmailSenderService : IEmailSenderService
{
    public async Task SendEmailAsync(SendEmailDTO dto)
    {
        using MimeMessage emailMessage = new();

        emailMessage.From.Add(new MailboxAddress("GalaxyExpress", "galaxyexpress7438@gmail.com"));
        emailMessage.To.Add(new MailboxAddress(string.Empty, dto.SendTo));
        emailMessage.Subject = dto.Subject; // It's a title.
        emailMessage.Body = new TextPart((dto.IsHtml) ? TextFormat.Html : TextFormat.Text)
        {
            Text = dto.Message
        };

        using (SmtpClient client = new())
        {
            await client.ConnectAsync("smtp.gmail.com", 465, true);
            await client.AuthenticateAsync("galaxyexpress7438@gmail.com", "zoxu nwcj yole imci");
            await client.SendAsync(emailMessage);

            await client.DisconnectAsync(true);
        }
    }
}