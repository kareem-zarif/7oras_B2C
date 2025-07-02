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
    public class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.UserName).HasMaxLength(100).IsRequired(true);
            builder.Property(x => x.Email).HasMaxLength(100).IsRequired(true);
            builder.Property(x => x.Password).IsRequired(true);

            builder.HasData(
                new Customer
                {
                    Id = Guid.NewGuid(),
                    UserName = "john_doe1",
                    Email = "john.doe1@example.com",
                    Phone = "123-456-7890",
                    Password = "hashed_password_1", 
                },
                new Customer
                {
                    Id = Guid.NewGuid(),
                    UserName = "jane_doe2",
                    Email = "jane.doe2@example.com",
                    Phone = "987-654-3210",
                    Password = "hashed_password_2"
                });
        }
    }
}
