namespace GalaxyExpress.DAL.Entities;

public class PromoCode : BaseEntity
{
    public Guid PromoCodeId
    {
        get => Id;
        set => Id = value;
    }

    public string Code { get; set; } = default!;
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public decimal BonusSize { get; set; }
    public int ActivationCounter { get; set; }

    public ICollection<UserPromoCode>? UserPromoCodes { get; set; }
}