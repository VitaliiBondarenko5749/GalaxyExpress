namespace GalaxyExpress.DAL.Entities;

public class Email
{
    public Guid EmailId { get; set; }
    public string EmailAddress { get; set; } = default!;
    public bool EmailConfirmed { get; set; } = false;

    public Guid UserId { get; set; } // FK
    public User User { get; set; } = default!;
}