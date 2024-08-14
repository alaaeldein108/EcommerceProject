using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Data.Entities.OrderEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.OwnsOne(order => order.ShippingAddress, x =>
            {
                x.WithOwner();
            });
            builder.HasOne(order => order.DeliveryMethod)
                .WithMany()
                .HasForeignKey(x=>x.DeliveryMethodId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(order => order.OrderItems).WithOne().OnDelete(DeleteBehavior.Cascade);
        }
    }
}
