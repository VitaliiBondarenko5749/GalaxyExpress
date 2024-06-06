namespace GalaxyExpress.DAL.Entities;

public class PhoneNumber : BaseEntity
{
    public Guid PhoneNumberId
    {
        get => Id;
        set => Id = value;
    }
    public string Number { get; set; } = default!;

    public Guid UserId { get; set; } // FK
    public User User { get; set; } = default!;
}
