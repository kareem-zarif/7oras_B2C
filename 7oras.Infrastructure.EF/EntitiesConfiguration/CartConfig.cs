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
    public class CartConfig : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();


            builder.HasData(
                new Cart
                {
                    Id = Guid.NewGuid(),
                    CustomerId = Guid.NewGuid()
                },
                new Cart
                {
                    Id = Guid.NewGuid(),
                    CustomerId = Guid.NewGuid()
                }
            );
        }
    }
}
