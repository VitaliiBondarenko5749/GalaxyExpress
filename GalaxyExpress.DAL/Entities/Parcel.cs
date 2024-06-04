namespace GalaxyExpress.DAL.Entities;

public enum Status
{
    Registered,
    Sent,
    OnTheWay,
    Delivered,
    Return
}

public enum MethodDelivery
{
    Standart,
    Special,
    ParcelMachine,
    Courier,
    Super
}

public enum TypePackaging
{
    CardboardBox,
    PlasticBag
}

public class Parcel : BaseEntity
{
    public Guid ParcelId
    {
        get => Id;
        set => Id = value;
    }

    public Guid SenderId { get; set; }
    public User Sender { get; set; } = default!;

    public Guid RecipientId { get; set; }
    public User Recipient { get; set; } = default!;

    public ulong InvoiceNumber { get; set; }
    public Status Status { get; set; }
    public MethodDelivery MethodDelivery { get; set; }
    public float ParcelWeight { get; set; }
    public string SenderAddress { get; set; } = default!;
    public string RecipientAddress { get; set; } = default!;
    public TypePackaging TypePackaging { get; set; }
    public int NumberOfPackages { get; set; }
    public bool LossCoverage { get; set; }
    public bool HomeDelivery { get; set; }
    public decimal DeliveryPrice { get; set; }
    public DateTime DateOfDispatch { get; set; }
    public DateTime DateOfReceipt { get; set; }

    public ICollection<UserParcel>? UserParcels { get; set; }
}