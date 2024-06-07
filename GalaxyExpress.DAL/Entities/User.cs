using Microsoft.AspNetCore.Identity;

namespace GalaxyExpress.DAL.Entities;

public enum Gender
{
    Male,
    Female,
    NotSelected
}

public class User : IdentityUser<Guid>, ICloneable
{
    public object Clone() => MemberwiseClone(); // implementation of the ICloneable interface

    public DateTime DateCreated { get; set; }
    public string Login { get; set; } = default!;
    // Password
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public string? FatherName { get; set; }
    public DateTime? Birthday { get; set; }
    public Gender Sex { get; set; }
    public string ImageDirectory { get; set; } = default!;
    public decimal BonusAccount { get; set; } = default!;
    public bool ActivatedAccount { get; set; } = false;

    public ICollection<PhoneNumber> PhoneNumbers { get; set; } = default!; // one to many
    public ICollection<Email> Emails { get; set; } = default!; // one to many
    public ICollection<PaymentCard> PaymentCards { get; set; } = default!; // one to many

    public ICollection<UserPromoCode>? UserPromoCodes { get; set; }
    public ICollection<UserPostBranch>? UserPostOffices { get; set; }
    public ICollection<UserParcelMachine>? UserParcelMachines { get; set; }
    public ICollection<UserParcel>? UserParcels { get; set; }
    public ICollection<Parcel>? SenderParcels { get; set; }
    public ICollection<Parcel>? RecipientParcels { get; set; }
}