namespace GalaxyExpress.BLL.DTOs.PhoneNumberDTOs;

public class PhoneNumberInfoDTO
{
    public Guid PhoneNumberId { get; set; }
    public Guid UserId { get; set; }
    public string Number { get; set; } = default!;
}