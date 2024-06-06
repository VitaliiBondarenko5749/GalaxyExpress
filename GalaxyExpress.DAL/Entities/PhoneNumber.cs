namespace GalaxyExpress.DAL.Entities;

public class PhoneNumber
{
    public Guid PhoneNumberId { get; set; }
    public string Number { get; set; } = default!;

    public Guid UserId { get; set; } // FK
    public User User { get; set; } = default!;
}