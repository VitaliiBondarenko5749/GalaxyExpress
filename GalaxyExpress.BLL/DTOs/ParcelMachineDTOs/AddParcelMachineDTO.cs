namespace GalaxyExpress.BLL.DTOs.ParcelMachineDTOs;

public class AddParcelMachineDTO
{
    public int ParcelMachineNumber { get; set; }
    public string LocalAddress { get; set; } = default!;
    public string GlobalAddress { get; set; } = default!;
    public float X { get; set; }
    public float Y { get; set; }
}