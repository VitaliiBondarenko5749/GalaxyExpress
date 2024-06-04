using GalaxyExpress.DAL.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GalaxyExpress.DAL.Data.Configurations;

public class UserPostBranchConfiguration : IEntityTypeConfiguration<UserPostBranch>
{
    public void Configure(EntityTypeBuilder<UserPostBranch> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.User)
            .WithMany(u => u.UserPostOffices)
            .HasForeignKey(x => x.UserId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(x => x.PostBranch)
            .WithMany(po => po.UserPostBranches)
            .HasForeignKey(x => x.PostBranchId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

        builder.ToTable("UserPostBranches");
    }
}
