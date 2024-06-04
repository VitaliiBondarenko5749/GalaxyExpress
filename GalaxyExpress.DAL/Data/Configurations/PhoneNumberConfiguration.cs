using GalaxyExpress.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyExpress.DAL.Data.Configurations
{
    public class PhoneNumberConfiguration : IEntityTypeConfiguration<PhoneNumber>
    {
        public void Configure(EntityTypeBuilder<PhoneNumber> builder)
        {
            builder.ToTable("PhoneNumbers");

            builder.HasKey(pn => pn.PhoneNumberId);

            builder
                .Property(pn => pn.DateCreated)
                .HasDefaultValueSql("GETUTCDATE()");


            builder
                .Property(pn => pn.Number)
                .HasColumnType("NVARCHAR(20)")
                .IsRequired();
            builder
                .HasIndex(pn => pn.Number)
                .IsUnique();


            builder // many to one - Users to PhoneNumbers
                .HasOne(pn => pn.User)
                .WithMany(u => u.PhoneNumbers)
                .HasForeignKey(pn => pn.UserId);
        }
    }
}
