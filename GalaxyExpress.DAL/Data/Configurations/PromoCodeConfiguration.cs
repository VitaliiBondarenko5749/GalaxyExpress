using GalaxyExpress.DAL.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GalaxyExpress.DAL.Data.Configurations;

public class PromoCodeConfiguration : IEntityTypeConfiguration<PromoCode>
{
    public void Configure(EntityTypeBuilder<PromoCode> builder)
    {
        builder.HasKey(pc => pc.PromoCodeId);

        builder.Property(pc => pc.Code)
            .IsRequired();

        builder.HasIndex(pc => pc.Code)
            .IsUnique();

        builder.Property(pc => pc.StartDate)
            .IsRequired();

        builder.Property(pc => pc.EndDate)
            .IsRequired();

        builder.Property(pc => pc.BonusSize)
            .IsRequired();

        builder.ToTable("PromoCodes");
    }
}