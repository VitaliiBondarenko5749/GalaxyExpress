namespace GalaxyExpress.DAL.Entities;

public class ParcelMachine
{
    public Guid ParcelMachineId { get; set; }
    public int ParcelMachineNumber { get; set; }
    public string LocalAddress { get; set; } = default!;
    public string GlobalAddress { get; set; } = default!;
    public string Coordinates { get; set; } = default!;

    public ICollection<UserParcelMachine>? UserParcelMachines { get; set; }
}