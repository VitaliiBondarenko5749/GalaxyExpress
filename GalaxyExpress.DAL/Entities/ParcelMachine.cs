namespace GalaxyExpress.DAL.Entities;

public class ParcelMachine : BaseEntity
{
    public Guid ParcelMachineId
    {
        get => Id; 
        set => Id = value;   
    }

    public int ParcelMachineNumber { get; set; }
    public string LocalAddress { get; set; } = default!;
    public string GlobalAddress { get; set; } = default!;
    public string Coordinates { get; set; } = default!;

    public ICollection<UserParcelMachine>? UserParcelMachines { get; set; }
}