using GalaxyExpress.DAL.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GalaxyExpress.DAL.Data.Configurations;

public class UserParcelMachineConfiguration : IEntityTypeConfiguration<UserParcelMachine>
{
    public void Configure(EntityTypeBuilder<UserParcelMachine> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.User)
            .WithMany(u => u.UserParcelMachines)
            .HasForeignKey(x => x.UserId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(x => x.ParcelMachine)
            .WithMany(pm => pm.UserParcelMachines)
            .HasForeignKey(x => x.ParcelMachineId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

        builder.ToTable("UserParcelMachines");
    }
}