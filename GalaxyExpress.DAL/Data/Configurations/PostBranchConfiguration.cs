using GalaxyExpress.DAL.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GalaxyExpress.DAL.Data.Configurations;

public class PostBranchConfiguration : IEntityTypeConfiguration<PostBranch>
{
    public void Configure(EntityTypeBuilder<PostBranch> builder)
    {
        builder.HasKey(pb => pb.BranchId);

        builder.Property(pb => pb.BranchNumber)
            .IsRequired();

        builder.Property(pb => pb.LocalAddress)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(pb => pb.GlobalAddress)
           .IsRequired()
           .HasMaxLength(100);

        builder.Property(pb => pb.Coordinates)
            .IsRequired()
            .HasMaxLength(100);

        builder.ToTable("PostBranches");
    }
}