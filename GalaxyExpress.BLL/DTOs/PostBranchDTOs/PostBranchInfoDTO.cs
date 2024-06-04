namespace GalaxyExpress.BLL.DTOs.PostBranchDTOs;

public class PostBranchInfoDTO
{
    public Guid BranchId { get; set; }
    public int BranchNumber { get; set; }
    public string LocalAddress { get; set; } = default!;
    public string GlobalAddress { get; set; } = default!;
    public float X { get; set; } = default!;
    public float Y { get; set; } = default!;
}