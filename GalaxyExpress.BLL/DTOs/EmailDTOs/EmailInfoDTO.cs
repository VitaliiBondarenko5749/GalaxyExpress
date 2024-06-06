namespace GalaxyExpress.BLL.DTOs.EmailDTOs;

public class EmailInfoDTO
{
    public Guid EmailId { get; set; }
    public Guid UserId { get; set; }
    public string EmailAddress { get; set; } = default!;
    public bool EmailConfirmed { get; set; }
}