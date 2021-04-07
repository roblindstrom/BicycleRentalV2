using BicycleRental.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BicycleRental.Persistence.Configurations
{
    public class BicycleConfiguration : IEntityTypeConfiguration<Bicycle>
    {

        public void Configure(EntityTypeBuilder<Bicycle> modelBuilder)
        {
            modelBuilder
                .HasKey(b => b.BicycleId);

            modelBuilder
                .HasMany(o => o.Orders)
                .WithOne(b => b.Bicycle)
                .HasForeignKey(o => o.BicycleID);
        }
    }
}
