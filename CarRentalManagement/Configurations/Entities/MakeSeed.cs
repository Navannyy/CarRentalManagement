using CarRentalManagement.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Configurations.Entities
{
    public class MakeSeed : IEntityTypeConfiguration<Make>
    {
        public void Configure(EntityTypeBuilder<Make> builder)
        {
            var date = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            builder.HasData(
                new Make { Id = 1, Name = "BMW", DateCreated = date, DateUpdated = date, CreatedBy = "System", UpdatedBy = "System" },
                new Make { Id = 2, Name = "Toyota", DateCreated = date, DateUpdated = date, CreatedBy = "System", UpdatedBy = "System" }
            );
        }
    }
}