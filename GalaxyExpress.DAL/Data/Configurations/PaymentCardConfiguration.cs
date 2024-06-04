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
    public class PaymentCardConfiguration : IEntityTypeConfiguration<PaymentCard>
    {
        public void Configure(EntityTypeBuilder<PaymentCard> builder)
        {
            builder.ToTable("PaymentCards");

            builder.HasKey(pc => pc.CardId);

            builder
                .Property(pc => pc.DateCreated)
                .HasDefaultValueSql("GETUTCDATE()");


            builder
                .Property(pc => pc.CardNumber)
                .HasColumnType("NVARCHAR(16)")
                .IsRequired();
            builder
                .Property(pc => pc.Validity)
                .HasColumnType("NVARCHAR(5)")
                .IsRequired();
            builder
                .Property(pc => pc.CVV)
                .HasColumnType("NVARCHAR(3)")
                .IsRequired();


            builder // many to one - Users to PaymentCards
                .HasOne(pc => pc.User)
                .WithMany(u => u.PaymentCards)
                .HasForeignKey(pc => pc.UserId);
        }
    }
}
