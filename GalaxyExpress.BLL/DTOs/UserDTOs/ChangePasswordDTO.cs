namespace GalaxyExpress.BLL.DTOs.UserDTOs;

public class ChangePasswordDTO
{
    public Guid UserId { get; set; }
    public string OldPassword { get; set; } = default!;
    public string NewPassword { get; set; } = default!;
    public string ConfirmNewPassword { get; set; } = default!;
}