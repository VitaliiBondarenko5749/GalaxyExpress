namespace GalaxyExpress.BLL.DTOs.EmailDTOs;

public class AddEmailDTO
{
    public Guid UserId { get; set; }
    public string Email { get; set; } = default!;
}