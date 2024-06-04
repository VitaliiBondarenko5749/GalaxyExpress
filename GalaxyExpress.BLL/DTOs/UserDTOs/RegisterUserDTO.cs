namespace GalaxyExpress.BLL.DTOs.UserDTOs;

public class RegisterUserDTO
{
    public string PhoneNumber { get; set; } = default!;
    public string Password { get; set; } = default!;
    public string ConfirmPassword { get; set; } = default!;
    public string Login {  get; set; } = default!;
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public string? FatherName { get; set; }
    public string Email { get; set; } = default!;
}