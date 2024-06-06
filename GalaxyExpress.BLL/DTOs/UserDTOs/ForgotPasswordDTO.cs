namespace GalaxyExpress.BLL.DTOs.UserDTOs;

public class ForgotPasswordDTO
{
    public Guid UserId { get; set; }
    public string Email { get; set; } = default!;
}