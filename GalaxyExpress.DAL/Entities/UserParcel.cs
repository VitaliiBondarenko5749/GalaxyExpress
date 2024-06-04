namespace GalaxyExpress.DAL.Entities;

public class UserParcel : BaseEntity
{
    public Guid UserId { get; set; }
    public User User { get; set; } = default!;

    public Guid ParcelId { get; set; }
    public Parcel Parcel { get; set; } = default!;

    public bool IsSender { get; set; }
}