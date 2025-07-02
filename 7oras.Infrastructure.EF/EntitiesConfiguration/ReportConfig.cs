using _7oras.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _7oras.Infrastructure.EF.EntitiesConfiguration
{
    public class ReportConfig : IEntityTypeConfiguration<Report>
    {
        public void Configure(EntityTypeBuilder<Report> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Reason).IsRequired(false).HasMaxLength(500);

            builder.HasData(
                new Report
                {
                    Id = Guid.NewGuid(),
                    Reason = "Sample report reason",
                    CustomerId = Guid.NewGuid(),
                    SupplierId = Guid.NewGuid()
                },
                new Report
                {
                    Id = Guid.NewGuid(),
                    Reason = "Another sample report reason",
                    CustomerId = Guid.NewGuid(),
                    SupplierId = Guid.NewGuid()
                }
            );
        }
    }
}
