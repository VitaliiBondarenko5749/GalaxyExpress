namespace GalaxyExpress.BLL.DTOs.EmailDTOs;

public class SendEmailDTO
{
    public string SendTo { get; set; } = default!;
    public string Subject { get; set; } = default!;
    public string Message { get; set; } = default!;
    public bool IsHtml { get; set; } = false;
}