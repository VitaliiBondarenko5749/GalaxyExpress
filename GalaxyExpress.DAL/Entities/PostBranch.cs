namespace GalaxyExpress.DAL.Entities;

public class PostBranch : BaseEntity
{
    public Guid BranchId
    {
        get => Id;
        set => Id = value;
    }

    public int BranchNumber { get; set; }
    public string LocalAddress { get; set; } = default!;
    public string GlobalAddress { get; set; } = default!;
    public string Coordinates { get; set; } = default!;

    public ICollection<UserPostBranch>? UserPostBranches { get; set; }
}