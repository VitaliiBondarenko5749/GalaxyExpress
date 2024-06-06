namespace GalaxyExpress.BLL.DTOs.UserDTOs;

public class ResetPasswordDTO
{
    public Guid UserId { get; set; }
    public string Token { get; set; } = default!;
    public string Password { get; set; } = default!;
    public string ConfirmPassword { get; set; } = default!;
}