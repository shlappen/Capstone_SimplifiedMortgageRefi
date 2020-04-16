using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SimplifiedMortgageRefi.Models;

namespace SimplifiedMortgageRefi.Data
{

    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<Applications_Customers> Applications_Customers { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Customers_Properties> Customers_Properties { get; set; }
        public DbSet<Income> Incomes { get; set; }
        public DbSet<Lender> Lenders { get; set; }
        public DbSet<Liability> Liabilities { get; set; }
        public DbSet<LiabilityType> LiabilityTypes { get; set; }
        public DbSet<LoanProfile> LoanProfiles { get; set; }
        public DbSet<OccupancyType> OccupancyTypes { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<PropertyType> PropertyTypes { get; set; }
        public DbSet<Purpose> Purposes { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>()
                .HasData(
                    new IdentityRole
                    {
                        Name = "Customer",
                        NormalizedName = "CUSTOMER"
                    }
                );
            builder.Entity<IdentityRole>()
                .HasData(
                    new IdentityRole
                    {
                    Name = "Lender",
                    NormalizedName = "LENDER"
                    }
                );

            builder.Entity<Application>()
                .HasMany(a => a.LoanProfiles)
                .WithOne(b => b.Application);

            builder.Entity<Application>()
                .HasMany(a => a.Contacts)
                .WithOne(b => b.Application);

            builder.Entity<Lender>()
                .HasMany(a => a.Contacts)
                .WithOne(b => b.Lender);

            builder.Entity<LoanProfile>()
                .HasMany(a => a.Incomes)
                .WithOne(b => b.LoanProfile);

            builder.Entity<LoanProfile>()
                .HasMany(a => a.Liabilities)
                .WithOne(b => b.LoanProfile)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Applications_Customers>()
                .HasKey(ab => new { ab.ApplicationId, ab.CustomerId });
            builder.Entity<Applications_Customers>()
                .HasOne(ab => ab.Application)
                .WithMany(b => b.Customers)
                .HasForeignKey(ab => ab.ApplicationId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.Entity<Applications_Customers>()
                .HasOne(ab => ab.Customer)
                .WithMany(b => b.Applications)
                .HasForeignKey(ab => ab.ApplicationId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Customers_Properties>()
                .HasKey(ab => new { ab.CustomerId, ab.PropertyId });
            builder.Entity<Customers_Properties>()
                .HasOne(ab => ab.Customer)
                .WithMany(b => b.Properties)
                .HasForeignKey(ab => ab.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.Entity<Customers_Properties>()
                .HasOne(ab => ab.Property)
                .WithMany(b => b.Customers)
                .HasForeignKey(ab => ab.PropertyId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
