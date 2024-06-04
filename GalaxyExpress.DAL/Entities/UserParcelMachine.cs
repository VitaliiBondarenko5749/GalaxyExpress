namespace GalaxyExpress.DAL.Entities;

public class UserParcelMachine : BaseEntity
{
    public Guid UserId { get; set; }
    public User User { get; set; } = default!;

    public Guid ParcelMachineId { get; set; }
    public ParcelMachine ParcelMachine { get; set; } = default!;
}