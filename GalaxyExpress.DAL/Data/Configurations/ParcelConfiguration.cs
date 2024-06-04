using GalaxyExpress.DAL.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GalaxyExpress.DAL.Data.Configurations;

public class ParcelConfiguration : IEntityTypeConfiguration<Parcel>
{
    public void Configure(EntityTypeBuilder<Parcel> builder)
    {
        builder.HasKey(p => p.ParcelId);

        builder.Property(p => p.InvoiceNumber)
            .IsRequired();

        builder.Property(p => p.Status)
            .IsRequired()
            .HasConversion<string>();

        builder.Property(p => p.MethodDelivery)
            .IsRequired()
            .HasConversion<string>();

        builder.Property(p => p.ParcelWeight)
            .IsRequired();

        builder.Property(p => p.SenderAddress)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(p => p.RecipientAddress)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(p => p.TypePackaging)
            .IsRequired()
            .HasConversion<string>();

        builder.Property(p => p.NumberOfPackages)
            .IsRequired()
            .HasDefaultValue(1);

        builder.Property(p => p.LossCoverage)
            .IsRequired()
            .HasDefaultValue(false);

        builder.Property(p => p.HomeDelivery)
           .IsRequired()
           .HasDefaultValue(false);

        builder.Property(p => p.DeliveryPrice)
            .IsRequired();

        builder.Property(p => p.DateOfDispatch)
            .IsRequired();

        builder.HasOne(p => p.Sender)
            .WithMany(s => s.SenderParcels)
            .HasForeignKey(p => p.SenderId)
            .IsRequired()
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(p => p.Recipient)
            .WithMany(s => s.RecipientParcels)
            .HasForeignKey(p => p.RecipientId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

        builder.ToTable("Parcels");
    }
}