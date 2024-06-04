namespace GalaxyExpress.BLL.DTOs.ParcelMachineDTOs;

public class ParcelMachineInfoDTO
{
    public Guid ParcelMachineId { get; set; }
    public int ParcelMachineNumber { get; set; }
    public string LocalAddress { get; set; } = default!;
    public string GlobalAddress { get; set; } = default!;
    public float X { get; set; } = default!;
    public float Y { get; set; } = default!;
}