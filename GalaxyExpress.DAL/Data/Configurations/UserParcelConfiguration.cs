using GalaxyExpress.DAL.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GalaxyExpress.DAL.Data.Configurations;

public class UserParcelConfiguration : IEntityTypeConfiguration<UserParcel>
{
    public void Configure(EntityTypeBuilder<UserParcel> builder)
    {
        builder.HasKey(up => up.Id);

        builder.HasOne(up => up.User)
            .WithMany(u => u.UserParcels)
            .HasForeignKey(up => up.UserId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(up => up.Parcel)
            .WithMany(p => p.UserParcels)
            .HasForeignKey(up => up.ParcelId)
            .IsRequired()
            .OnDelete(DeleteBehavior.NoAction);

        builder.Property(up => up.IsSender)
            .IsRequired()
            .HasDefaultValue(false);

        builder.ToTable("UserParcels");
    }
}
