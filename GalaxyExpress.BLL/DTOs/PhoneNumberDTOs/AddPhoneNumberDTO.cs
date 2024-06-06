namespace GalaxyExpress.BLL.DTOs.PhoneNumberDTOs;

public class AddPhoneNumberDTO
{
    public Guid UserId { get; set; }
    public string PhoneNumber { get; set; } = default!;
}