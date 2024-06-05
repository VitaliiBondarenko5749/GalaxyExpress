using Bogus;
using GalaxyExpress.DAL.Entities;
using GalaxyExpress.DAL.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace GalaxyExpress.DAL.Bogus
{
    public class DataGenerator
    {
        public static List<Email> Emails = new();
        public static List<PhoneNumber> PhoneNumbers = new();
        public static List<PaymentCard> PaymentCards = new();

        public static List<User> Users = new();
        public static List<IdentityRole<Guid>> Roles = new();
        public static List<IdentityUserRole<Guid>> UsersRoles = new();

        private const int USERS = 140;
        private const int EMAILS = USERS * 2;
        private const int PHONENUMBERS = USERS * 2;
        private const int PAYMENTCARDS = USERS * 2;

        #region Vitalii Lists

        public static List<ParcelMachine> ParcelMachines = new();
        public static List<PostBranch> PostBranches = new();
        public static List<PromoCode> PromoCodes = new();
        public static List<UserParcelMachine> UserParcelMachines = new();
        public static List<UserPostBranch> UserPostBranches = new();
        public static List<UserPromoCode> UserPromoCodes = new();

        #endregion

        #region Vitalii Methods

        public static List<Parcel> GenerateFakeParcels()
        {
            Faker faker = new();

            List<Parcel> parcels = new();

            for (int i = 0; i < 100; i++)
            {
                User sender = faker.PickRandom(Users);

                User recipient;
                do
                {
                    recipient = faker.PickRandom(Users);
                } while (recipient.Id == sender.Id);

                Faker<Parcel> fakeParcel = new Faker<Parcel>()
                    .RuleFor(p => p.ParcelId, f => Guid.NewGuid())
                    .RuleFor(p => p.SenderId, f => sender.Id)
                    .RuleFor(p => p.RecipientId, f => recipient.Id)
                    .RuleFor(p => p.InvoiceNumber, f => f.Random.ULong(1000000000000000, 9999999999999999))
                    .RuleFor(p => p.Status, f => f.PickRandom<Status>())
                    .RuleFor(p => p.MethodDelivery, f => f.PickRandom<MethodDelivery>())
                    .RuleFor(p => p.ParcelWeight, f => f.Random.Float(0.1f, 50.0f))
                    .RuleFor(p => p.SenderAddress, f => f.Address.FullAddress())
                    .RuleFor(p => p.RecipientAddress, f => f.Address.FullAddress())
                    .RuleFor(p => p.TypePackaging, f => f.PickRandom<TypePackaging>())
                    .RuleFor(p => p.NumberOfPackages, f => f.Random.Int(1, 5))
                    .RuleFor(p => p.LossCoverage, f => f.Random.Bool())
                    .RuleFor(p => p.HomeDelivery, f => f.Random.Bool())
                    .RuleFor(p => p.DeliveryPrice, f => f.Finance.Amount(10, 100))
                    .RuleFor(p => p.DateOfDispatch, f => f.Date.Past(1))
                    .RuleFor(p => p.DateOfReceipt, (f, p) => p.DateOfDispatch.AddDays(f.Random.Int(1, 10)));

                parcels.Add(fakeParcel.Generate());
            }

            return parcels;
        }

        private static Faker<ParcelMachine> GetParcelMachineGenerator()
        {
            return new Faker<ParcelMachine>()
                .RuleFor(pm => pm.ParcelMachineId, _ => Guid.NewGuid())
                .RuleFor(pm => pm.ParcelMachineNumber, f => f.Random.Int(1, 200))
                .RuleFor(pm => pm.LocalAddress, f => $"{f.Address.StreetName()}, {f.Address.BuildingNumber()}")
                .RuleFor(pm => pm.GlobalAddress, f => $"{f.Address.City()}, {f.Address.Country()}")
                .RuleFor(pm => pm.Coordinates, f => $"{f.Random.Float(48.0F, 51.0F)};{f.Random.Float(23.0F, 31.0F)}");
        }

        private static Faker<PostBranch> GetPostBranchGenerator()
        {
            return new Faker<PostBranch>()
                .RuleFor(pb => pb.Id, _ => Guid.NewGuid())
                .RuleFor(pb => pb.BranchNumber, f => f.Random.Int(1, 200))
                .RuleFor(pm => pm.LocalAddress, f => $"{f.Address.StreetName()}, {f.Address.BuildingNumber()}")
                .RuleFor(pm => pm.GlobalAddress, f => $"{f.Address.City()}, {f.Address.Country()}")
                .RuleFor(pm => pm.Coordinates, f => $"{f.Random.Float(48.0F, 51.0F)};{f.Random.Float(23.0F, 31.0F)}");
        }

        private static Faker<PromoCode> GetPromoCodeGenerator()
        {
            return new Faker<PromoCode>()
                .RuleFor(pc => pc.PromoCodeId, _ => Guid.NewGuid())
                .RuleFor(pc => pc.Code, f => f.Finance.LitecoinAddress())
                .RuleFor(pc => pc.StartDate, f => DateTime.Now)
                .RuleFor(pc => pc.EndDate, f => DateTime.Now.AddDays(5))
                .RuleFor(pc => pc.BonusSize, f => f.Random.Decimal())
                .RuleFor(pc => pc.ActivationCounter, f => f.Random.Int());
        }

        #endregion

        private static Faker<User> GetUserGenerator()
        {
            return new Faker<User>()
                .RuleFor(u => u.Id, _ => Guid.NewGuid())
                .RuleFor(u => u.Login, f => f.Person.UserName)
                .RuleFor(u => u.FirstName, f => f.Person.FirstName)
                .RuleFor(u => u.LastName, f => f.Person.LastName)
                .RuleFor(u => u.FatherName, f => f.Random.Int(0, 100) > 50 ? f.Person.FirstName : null)
                .RuleFor(u => u.Birthday, f =>
                    f.Random.Int(0, 100) > 50 ? f.Date.Between(DateTime.Now.AddYears(-100), DateTime.Now.AddYears(-15)) : null)
                .RuleFor(u => u.Sex, f => f.PickRandom<Gender>())
                .RuleFor(u => u.BonusAccount, f => f.Random.Decimal(0.0m, 1000.0m))
                .RuleFor(u => u.PasswordHash, f => new PasswordHasher<User>().HashPassword(null!, f.Internet.Password()))
                .RuleFor(u => u.ActivatedAccount, f => f.Random.Bool());
        }

        private static Faker<PhoneNumber> GetPhoneNumberGenerator(Guid UserId)
        {
            return new Faker<PhoneNumber>()
                .RuleFor(pn => pn.PhoneNumberId, _ => Guid.NewGuid())
                .RuleFor(pn => pn.Number, f => $"+{f.Random.Int(1, 999)} {f.Phone.PhoneNumber(@"## (###) ##-##")}")
                .RuleFor(pn => pn.UserId, _ => UserId);
        }
        private static Faker<PaymentCard> GetPaymentCardGenerator(Guid UserId)
        {
            return new Faker<PaymentCard>()
                .RuleFor(pc => pc.CardId, _ => Guid.NewGuid())
                .RuleFor(pc => pc.CardNumber, f => $"{f.Random.Int(1, 9)}{f.Phone.PhoneNumber(@"###############")}")
                .RuleFor(pc => pc.Validity, f => $"{f.Random.Int(1, 12):D2}/{f.Random.Int(1, 28):D2}")
                .RuleFor(pc => pc.CVV, f => f.Phone.PhoneNumber(@"###"))
                .RuleFor(pc => pc.UserId, _ => UserId);
        }
        private static Faker<Email> GetEmailGenerator(Guid UserId)
        {
            return new Faker<Email>()
                .RuleFor(e => e.EmailId, _ => Guid.NewGuid())
                .RuleFor(e => e.EmailAddress, f => f.Internet.Email())
                .RuleFor(e => e.UserId, _ => UserId);
        }

        public static void InitBogusData()
        {
            Faker faker = new();

            // Add IdentityRoles
            Roles.AddRange(new List<IdentityRole<Guid>>
            {
                new IdentityRole<Guid>
                {
                    Id = Guid.NewGuid(),
                    Name = Authorization.Roles.Admin.ToString(),
                    NormalizedName = Authorization.Roles.Admin.ToString().ToUpper()
                },
                new IdentityRole<Guid>
                {
                    Id = Guid.NewGuid(),
                    Name = Authorization.Roles.Manager.ToString(),
                    NormalizedName = Authorization.Roles.Manager.ToString().ToUpper()
                },
                new IdentityRole<Guid>
                {
                    Id = Guid.NewGuid(),
                    Name = Authorization.Roles.User.ToString(),
                    NormalizedName = Authorization.Roles.User.ToString().ToUpper()
                }
            });

            Roles = Roles.DistinctBy(r => r.Name)
                .DistinctBy(r => r.NormalizedName).ToList();

            // Add IdentityUsers
            Users.AddRange(GetUserGenerator().Generate(USERS));

            var userRoles = new HashSet<(Guid UserId, Guid RoleId)>();
            foreach (User user in Users)
            {
                Guid roleId;
                do
                {
                    roleId = faker.PickRandom(Roles).Id;
                } while (!userRoles.Add((user.Id, roleId)));

                UsersRoles.Add(new IdentityUserRole<Guid>
                {
                    RoleId = roleId,
                    UserId = user.Id
                });
            }

            Users.ForEach(user => Emails.AddRange(GetEmailGenerator(user.Id).Generate(2)));
            Users.ForEach(user => PhoneNumbers.AddRange(GetPhoneNumberGenerator(user.Id).Generate(2)));
            Users.ForEach(user => PaymentCards.AddRange(GetPaymentCardGenerator(user.Id).Generate(2)));

            ParcelMachines.AddRange(GetParcelMachineGenerator().Generate(50));
            PostBranches.AddRange(GetPostBranchGenerator().Generate(50));
            PromoCodes.AddRange(GetPromoCodeGenerator().Generate(50));

            for (int i = 0; i < 30; ++i)
            {
                Guid userId = faker.PickRandom(Users).Id,
                    parcelMachineId = faker.PickRandom(ParcelMachines).ParcelMachineId,
                    postBranchId = faker.PickRandom(PostBranches).BranchId,
                    promoCodeId = faker.PickRandom(PromoCodes).Id;

                UserParcelMachines.Add(new UserParcelMachine { Id = Guid.NewGuid(), UserId = userId, ParcelMachineId = parcelMachineId });
                UserPostBranches.Add(new UserPostBranch { Id = Guid.NewGuid(), UserId = userId, PostBranchId = postBranchId });
                UserPromoCodes.Add(new UserPromoCode { Id = Guid.NewGuid(), UserId = userId, PromoCodeId = promoCodeId });
            }
        }
    }
}
