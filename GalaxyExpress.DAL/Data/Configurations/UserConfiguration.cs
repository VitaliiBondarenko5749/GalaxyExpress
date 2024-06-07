using GalaxyExpress.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GalaxyExpress.DAL.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("AspNetUsers");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Sex)
                .HasConversion<string>()
                .HasDefaultValue(Gender.NotSelected);

            builder
                .Property(u => u.DateCreated)
                .HasDefaultValueSql("GETUTCDATE()");

            builder
                .Property(u => u.Login)
                .HasColumnType("NVARCHAR(100)")
                .IsRequired();

            builder
                .HasIndex(u => u.Login)
                .IsUnique();

            builder
                .Property(u => u.FirstName)
                .HasColumnType("NVARCHAR(100)")
                .IsRequired();
            builder
                .Property(u => u.LastName)
                .HasColumnType("NVARCHAR(100)")
                .IsRequired();
            builder
                .Property(u => u.FatherName)
                .HasColumnType("NVARCHAR(100)");
            builder
                .Property(u => u.Birthday)
                .HasColumnType("DATETIME2");
            builder
                .Property(u => u.BonusAccount)
                .HasColumnType("DECIMAL(18,2)")
                .HasDefaultValue(0);

            builder.Property(u => u.ActivatedAccount)
                .HasDefaultValue(false);

            builder.Property(u => u.ImageDirectory)
                .HasDefaultValue("/UserIcons/Default-icon.png");

            builder // one to many - Users to PhoneNumbers
                .HasMany(u => u.PhoneNumbers)
                .WithOne(pn => pn.User)
                .HasForeignKey(pn => pn.UserId)
                .OnDelete(DeleteBehavior.Cascade);
            builder // one to many - Users to Emails
                .HasMany(u => u.Emails)
                .WithOne(e => e.User)
                .HasForeignKey(e => e.UserId)
                .OnDelete(DeleteBehavior.Cascade);
            builder // one to many - Users to PaymentCards
                .HasMany(u => u.PaymentCards)
                .WithOne(pc => pc.User)
                .HasForeignKey(pc => pc.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // Ignore attributes

            builder.Ignore(u => u.UserName);
            builder.Ignore(u => u.NormalizedUserName);

            builder.Property(u => u.UserName)
                .IsRequired(false)
                .HasDefaultValue("None");

            builder.Property(u => u.NormalizedUserName)
                .IsRequired(false)
                .HasDefaultValue("NONE");

            builder.Ignore(u => u.Email);
            builder.Ignore(u => u.NormalizedEmail);
            builder.Ignore(u => u.EmailConfirmed);

            builder.Ignore(u => u.PhoneNumber);
            builder.Ignore(u => u.PhoneNumberConfirmed);
        }
    }
}