using BicycleRental.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleRental.Persistence.Configurations
{
    public class CustomerAddressConfiguration : IEntityTypeConfiguration<CustomerAddress>
    {
        public void Configure(EntityTypeBuilder<CustomerAddress> modelBuilder)
        {
            modelBuilder
                .HasKey(ca => new { ca.CustomerAddressID, ca.AddressID });

            modelBuilder
                .HasOne(ca => ca.Customer)
                .WithMany(c => c.CustomerAddresses)
                .HasForeignKey(ca => ca.CustomerAddressID);

            modelBuilder
                .HasOne(ca => ca.Address)
                .WithMany(a => a.CustomerAddresses)
                .HasForeignKey(a => a.AddressID);
        }
    }
}
