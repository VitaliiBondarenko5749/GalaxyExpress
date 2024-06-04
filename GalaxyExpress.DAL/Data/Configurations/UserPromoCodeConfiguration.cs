using GalaxyExpress.DAL.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GalaxyExpress.DAL.Data.Configurations;

public class UserPromoCodeConfiguration : IEntityTypeConfiguration<UserPromoCode>
{
    public void Configure(EntityTypeBuilder<UserPromoCode> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.User)
            .WithMany(u => u.UserPromoCodes)
            .HasForeignKey(x => x.UserId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(x => x.PromoCode)
            .WithMany(pc => pc.UserPromoCodes)
            .HasForeignKey(x => x.PromoCodeId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

        builder.ToTable("UserPromoCodes");
    }
}