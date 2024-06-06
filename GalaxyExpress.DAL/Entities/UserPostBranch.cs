namespace GalaxyExpress.DAL.Entities;

public class UserPostBranch
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public User User { get; set; } = default!;

    public Guid PostBranchId { get; set; }
    public PostBranch PostBranch { get; set; } = default!;
}