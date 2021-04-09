using BicycleRental.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleRental.Persistence.Configurations
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> modelBuilder)
        {
            modelBuilder
                .HasKey(a => a.AddressID);

           

            modelBuilder
                .HasMany(a => a.CustomerAddresses)
                .WithOne(ca => ca.Address)
                .HasForeignKey(ca => ca.AddressID);
        }
    }
}
