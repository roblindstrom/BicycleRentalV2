using BicycleRental.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace BicycleRental.Persistence.Configurations
{
    public class BicycleConfiguration : IEntityTypeConfiguration<Bicycle>
    {

        public void Configure(EntityTypeBuilder<Bicycle> modelBuilder)
        {
            modelBuilder
                .HasKey(b => b.BicycleId);

            modelBuilder
                .Property(b => b.BicycleId)
                .ValueGeneratedNever();

            modelBuilder
                .HasMany(o => o.Orders)
                .WithOne(b => b.Bicycle)
                .HasForeignKey(o => o.BicycleID);

            //modelBuilder
            //    .Property(b => b.BicycleBrand)
            //    .HasConversion<int>();

            //modelBuilder
            //   .Property(x => x.BicycleBrand)
            //    .HasConversion(x => x.ToString(), y => (BicycleBrand)Enum.Parse(typeof(BicycleBrand), y));
        }
    }
}
