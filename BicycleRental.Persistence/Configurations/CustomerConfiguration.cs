using BicycleRental.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleRental.Persistence.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> modelBuilder)
        {
            modelBuilder
                .HasKey(c => c.CustomerID);

            modelBuilder
                .Property(c => c.CustomerID)
                .ValueGeneratedNever();

            modelBuilder
                .HasMany(o => o.Orders)
                .WithOne(c => c.Customer)
                .HasForeignKey(o => o.CustomerID);

            modelBuilder
                .HasMany(ca => ca.CustomerAddresses)
                .WithOne(c => c.Customer)
                .HasForeignKey(ca => ca.CustomerAddressID);

           

                
        }

        
    }
}
