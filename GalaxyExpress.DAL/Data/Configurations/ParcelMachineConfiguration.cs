using GalaxyExpress.DAL.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GalaxyExpress.DAL.Data.Configurations;

public class ParcelMachineConfiguration : IEntityTypeConfiguration<ParcelMachine>
{
    public void Configure(EntityTypeBuilder<ParcelMachine> builder)
    {
        builder.HasKey(pm => pm.ParcelMachineId);

        builder.Property(pm => pm.ParcelMachineNumber)
            .IsRequired();

        builder.Property(pm => pm.LocalAddress)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(pm => pm.GlobalAddress)
           .IsRequired()
           .HasMaxLength(100);

        builder.Property(pm => pm.Coordinates)
            .IsRequired()
            .HasMaxLength(100);

        builder.ToTable("ParcelMachines");
    }
}
