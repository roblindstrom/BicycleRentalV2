using BicycleRental.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleRental.Persistence.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {

        public void Configure(EntityTypeBuilder<Order> modelBuilder)
        {
            modelBuilder
                .HasKey(o => new { o.BicycleID, o.CustomerID });

            modelBuilder
                .HasOne(o => o.Bicycle)
                .WithMany(b => b.Orders)
                .HasForeignKey(o => o.BicycleID);

            modelBuilder
                .HasOne(c => c.Customer)
                .WithMany(o => o.Orders)
                .HasForeignKey(o => o.CustomerID);
        }


    }
}
