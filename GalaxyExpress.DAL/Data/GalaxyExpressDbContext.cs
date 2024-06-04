using GalaxyExpress.DAL.Bogus;
using GalaxyExpress.DAL.Data.Configurations;
using GalaxyExpress.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

#pragma warning disable

namespace GalaxyExpress.DAL.Data
{
    public class GalaxyExpressDbContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>
    {
        public DbSet<Email> Emails { get; set; } = default!;
        public DbSet<PhoneNumber> PhoneNumbers { get; set; } = default!;
        public DbSet<PaymentCard> PaymentCards { get; set; } = default!;

        public DbSet<PromoCode> PromoCodes => Set<PromoCode>();
        public DbSet<PostBranch> PostBranches => Set<PostBranch>();
        public DbSet<ParcelMachine> ParcelMachines => Set<ParcelMachine>();
        public DbSet<Parcel> Parcels => Set<Parcel>();
        public DbSet<UserParcel> UserParcels => Set<UserParcel>();
        public DbSet<UserPromoCode> UserPromoCodes => Set<UserPromoCode>();
        public DbSet<UserPostBranch> UserPostOffices => Set<UserPostBranch>();
        public DbSet<UserParcelMachine> UserParcelMachines => Set<UserParcelMachine>();

        public GalaxyExpressDbContext (DbContextOptions<GalaxyExpressDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Initial Catalog=GalaxyExpressDb;Trusted_Connection=True;TrustServerCertificate=True;")
                    .EnableSensitiveDataLogging();
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new PhoneNumberConfiguration());
            builder.ApplyConfiguration(new EmailConfiguration());
            builder.ApplyConfiguration(new PaymentCardConfiguration());

            builder.ApplyConfiguration(new PromoCodeConfiguration());
            builder.ApplyConfiguration(new PostBranchConfiguration());
            builder.ApplyConfiguration(new ParcelMachineConfiguration());
            builder.ApplyConfiguration(new ParcelConfiguration());
            builder.ApplyConfiguration(new UserParcelConfiguration());
            builder.ApplyConfiguration(new UserPromoCodeConfiguration());
            builder.ApplyConfiguration(new UserPostBranchConfiguration());
            builder.ApplyConfiguration(new UserParcelMachineConfiguration());

            // Seeding data
            DataGenerator.InitBogusData();

            List<IdentityUserRole<Guid>> uniqueRoles = DataGenerator.UsersRoles
                .GroupBy(ur => new { ur.UserId, ur.RoleId })
                .Select(g => g.First())
                .ToList();

            builder.Entity<IdentityRole<Guid>>().HasData(DataGenerator.Roles);
            builder.Entity<User>().HasData(DataGenerator.Users);
            builder.Entity<IdentityUserRole<Guid>>().HasData(uniqueRoles);

            builder.Entity<PhoneNumber>().HasData(DataGenerator.PhoneNumbers);
            builder.Entity<Email>().HasData(DataGenerator.Emails);
            builder.Entity<PaymentCard>().HasData(DataGenerator.PaymentCards);

            builder.Entity<ParcelMachine>().HasData(DataGenerator.ParcelMachines);
            builder.Entity<PostBranch>().HasData(DataGenerator.PostBranches);
            builder.Entity<PromoCode>().HasData(DataGenerator.PromoCodes);
            builder.Entity<UserParcelMachine>().HasData(DataGenerator.UserParcelMachines);
            builder.Entity<UserPostBranch>().HasData(DataGenerator.UserPostBranches);
            builder.Entity<UserPromoCode>().HasData(DataGenerator.UserPromoCodes);

            // Add UserParcels data automatically.
            builder.Entity<Parcel>().HasData(DataGenerator.GenerateFakeParcels());
        }
    }
}
