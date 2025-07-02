using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _7oras.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _7oras.Infrastructure.EF.EntitiesConfiguration
{
     public class OrderItemConfig : IEntityTypeConfiguration<OrderItem>
     {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Quantity).IsRequired(true);
            builder.Property(x => x.UnitPrice).IsRequired(true);

            builder.HasData(
                new OrderItem
                {
                    Id = Guid.NewGuid(),
                    Quantity = 2,
                    UnitPrice = 50.0, 
                    ProductId = Guid.NewGuid(),
                    OrderId = Guid.NewGuid() 
                },
                new OrderItem
                {
                    Id = Guid.NewGuid(),
                    Quantity = 1,
                    UnitPrice = 100.0, 
                    ProductId = Guid.NewGuid(),
                    OrderId = Guid.NewGuid()
                }
            );

        }
    }
}
