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
    public class PersonConfig : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.UserName).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Phone).IsRequired(false);
            builder.Property(x => x.Password).IsRequired(true);

            builder.HasData(
                new Person
                {
                    Id = Guid.NewGuid(),
                    UserName = "admin",
                    Email = "admin@example.com",
                    Phone = "1234567890",
                    Password = "Admin@123", 
                },
                new Person
                {
                    Id = Guid.NewGuid(),
                    UserName = "user1",
                    Email = "user1@example.com",
                    Phone = "1234567890",
                    Password = "User1@123",
                },
                new Person
                {
                    Id = Guid.NewGuid(),
                    UserName = "user2",
                    Email = "user2@example.com",
                    Phone = "1234567890",
                    Password = "User2@123",
                }
            );
        }
    }
}
