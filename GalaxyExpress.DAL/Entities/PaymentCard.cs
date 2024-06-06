namespace GalaxyExpress.DAL.Entities;

public class PaymentCard
{
    public Guid CardId { get; set; }
    public string CardNumber { get; set; } = default!;
    public string Validity { get; set; } = default!; // "03/24"
    public string CVV { get; set; } = default!; 

    public Guid UserId { get; set; } // FK
    public User User { get; set; } = default!;
}