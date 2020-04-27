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
        public DbSet<Lender> Lenders { get; set; }
        public DbSet<Liabilities_LoanProfiles> Liabilities_LoanProfiles {get; set;}
        public DbSet<Liability> Liabilities { get; set; }
        public DbSet<LiabilityType> LiabilityTypes { get; set; }
        public DbSet<LoanProfile> LoanProfiles { get; set; }
        public DbSet<OccupancyType> OccupancyTypes { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<PropertyType> PropertyTypes { get; set; }
        public DbSet<Purpose> Purposes { get; set; }
        public DbSet<USState> States { get; set; }



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

            builder.Entity<USState>()
                .HasData(
                    new USState
                    {
                        Id = 1,
                        Name = "Alabama",
                        Abbreviation = "AL"
                    },
                    new USState
                    {
                        Id = 2,
                        Name = "Alaska",
                        Abbreviation = "AK"
                    },
                    new USState
                    {
                        Id = 3,
                        Name = "Arizona",
                        Abbreviation = "AZ"
                    },
                    new USState
                    {
                        Id = 4,
                        Name = "Arkansas",
                        Abbreviation = "AR"
                    },
                    new USState
                    {
                        Id = 5,
                        Name = "California",
                        Abbreviation = "CA"
                    },
                    new USState
                    {
                        Id = 6,
                        Name = "Colorado",
                        Abbreviation = "CO"
                    },
                    new USState
                    {
                        Id = 7,
                        Name = "Connecticut",
                        Abbreviation = "CT"
                    },
                    new USState
                    {
                        Id = 8,
                        Name = "District of Columbia",
                        Abbreviation = "DC"
                    },
                    new USState
                    {
                        Id = 9,
                        Name = "Delaware",
                        Abbreviation = "DE"
                    },
                    new USState
                    {
                        Id = 10,
                        Name = "Florida",
                        Abbreviation = "FL"
                    },
                    new USState
                    {
                        Id = 11,
                        Name = "Georgia",
                        Abbreviation = "GA"
                    },
                    new USState
                    {
                        Id = 12,
                        Name = "Hawaii",
                        Abbreviation = "HI"
                    },
                    new USState
                    {
                        Id = 13,
                        Name = "Idaho",
                        Abbreviation = "ID"
                    },
                    new USState
                    {
                        Id = 14,
                        Name = "Illinois",
                        Abbreviation = "IL"
                    },
                    new USState
                    {
                        Id = 15,
                        Name = "Indiana",
                        Abbreviation = "IN"
                    },
                    new USState
                    {
                        Id = 16,
                        Name = "Iowa",
                        Abbreviation = "IA"
                    },
                    new USState
                    {
                        Id = 17,
                        Name = "Kansas",
                        Abbreviation = "KS"
                    },
                    new USState
                    {
                        Id = 18,
                        Name = "Kentucky",
                        Abbreviation = "KY"
                    },
                    new USState
                    {
                        Id = 19,
                        Name = "Louisiana",
                        Abbreviation = "LA"
                    },
                    new USState
                    {
                        Id = 20,
                        Name = "Maine",
                        Abbreviation = "ME"
                    },
                    new USState
                    {
                        Id = 21,
                        Name = "Maryland",
                        Abbreviation = "MD"
                    },
                    new USState
                    {
                        Id = 22,
                        Name = "Massachusetts",
                        Abbreviation = "MA"
                    },
                    new USState
                    {
                        Id = 23,
                        Name = "Michigan",
                        Abbreviation = "MI"
                    },
                    new USState
                    {
                        Id = 24,
                        Name = "Minnesota",
                        Abbreviation = "MN"
                    },
                    new USState
                    {
                        Id = 25,
                        Name = "Mississippi",
                        Abbreviation = "MS"
                    },
                    new USState
                    {
                        Id = 26,
                        Name = "Missouri",
                        Abbreviation = "MO"
                    },
                    new USState
                    {
                        Id = 27,
                        Name = "Montana",
                        Abbreviation = "MT"
                    },
                    new USState
                    {
                        Id = 28,
                        Name = "Nebraska",
                        Abbreviation = "NE"
                    },
                    new USState
                    {
                        Id = 29,
                        Name = "Nevada",
                        Abbreviation = "NV"
                    },
                    new USState
                    {
                        Id = 30,
                        Name = "New Hampshire",
                        Abbreviation = "NH"
                    },
                    new USState
                    {
                        Id = 31,
                        Name = "New Jersey",
                        Abbreviation = "NJ"
                    },
                    new USState
                    {
                        Id = 32,
                        Name = "New Mexico",
                        Abbreviation = "NM"
                    },
                    new USState
                    {
                        Id = 33,
                        Name = "New York",
                        Abbreviation = "NY"
                    },
                    new USState
                    {
                        Id = 34,
                        Name = "North Carolina",
                        Abbreviation = "NC"
                    },
                    new USState
                    {
                        Id = 35,
                        Name = "North Dakota",
                        Abbreviation = "ND"
                    },
                    new USState
                    {
                        Id = 36,
                        Name = "Ohio",
                        Abbreviation = "OH"
                    },
                    new USState
                    {
                        Id = 37,
                        Name = "Oklahoma",
                        Abbreviation = "OK"
                    },
                    new USState
                    {
                        Id = 38,
                        Name = "Oregon",
                        Abbreviation = "OR"
                    },
                    new USState
                    {
                        Id = 39,
                        Name = "Pennsylvania",
                        Abbreviation = "PA"
                    },
                    new USState
                    {
                        Id = 40,
                        Name = "Rhode Island",
                        Abbreviation = "RH"
                    },
                    new USState
                    {
                        Id = 41,
                        Name = "South Carolina",
                        Abbreviation = "SC"
                    },
                    new USState
                    {
                        Id = 42,
                        Name = "South Dakota",
                        Abbreviation = "SD"
                    },
                    new USState
                    {
                        Id = 43,
                        Name = "Tennessee",
                        Abbreviation = "TN"
                    },
                    new USState
                    {
                        Id = 44,
                        Name = "Texas",
                        Abbreviation = "TX"
                    },
                    new USState
                    {
                        Id = 45,
                        Name = "Utah",
                        Abbreviation = "UT"
                    },
                    new USState
                    {
                        Id = 46,
                        Name = "Vermont",
                        Abbreviation = "VT"
                    },
                    new USState
                    {
                        Id = 47,
                        Name = "Virginia",
                        Abbreviation = "VA"
                    },
                    new USState
                    {
                        Id = 48,
                        Name = "Washington",
                        Abbreviation = "WA"
                    },
                    new USState
                    {
                        Id = 49,
                        Name = "West Virginia",
                        Abbreviation = "WV"
                    },
                    new USState
                    {
                        Id = 50,
                        Name = "Wisconsin",
                        Abbreviation = "WI"
                    },
                    new USState
                    {
                        Id = 51,
                        Name = "Wyoming",
                        Abbreviation = "WY"
                    }
                );

            builder.Entity<Purpose>()
                .HasData(new Purpose
                {
                    Id = 1,
                    Name = "lower my rate and payment"
                },
                new Purpose
                {
                    Id = 2,
                    Name = "tap into my equity"
                },
                new Purpose
                {
                    Id = 3,
                    Name = "shorten my term"
                },
                new Purpose
                {
                    Id = 4,
                    Name = "other"
                }
            );
            builder.Entity<PropertyType>()
           .HasData(new PropertyType
           {
               Id = 1,
               Name = "Single Family"
           },
           new PropertyType
           {
               Id = 2,
               Name = "Condominium"
           },
           new PropertyType
           {
               Id = 3,
               Name = "Townhouse"
           },
           new PropertyType
           {
               Id = 4,
               Name = "Multi-Family"
           },
           new PropertyType
           {
               Id = 5,
               Name = "Other"
           }
       );
            builder.Entity<OccupancyType>()
           .HasData(new OccupancyType
           {
               Id = 1,
               Name = "Primary Residence"
           },
           new OccupancyType
           {
               Id = 2,
               Name = "Investment Property"
           },
           new OccupancyType
           {
               Id = 3,
               Name = "Second Home"
           },
           new OccupancyType
           {
               Id = 4,
               Name = "Family Member Lives Here"
           },
           new OccupancyType
           {
               Id = 5,
               Name = "Other"
           }
       );
            builder.Entity<LiabilityType>()
                .HasData(new LiabilityType
                {
                    Id = 1,
                    Name = "Credit Card"
                },
                new LiabilityType
                {
                    Id = 2,
                    Name = "Loan"
                },
                new LiabilityType
                {
                    Id = 3,
                    Name = "Lease"
                },
                new LiabilityType
                {
                    Id = 4,
                    Name = "Mortgage"
                }
        );

            builder.Entity<Application>()
                .HasOne(a => a.Property)
                .WithMany(b => b.Applications)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Application>()
                .HasMany(a => a.LoanProfiles)
                .WithOne(b => b.Application);

            builder.Entity<Application>()
                .HasMany(a => a.Contacts)
                .WithOne(b => b.Application);

            builder.Entity<Lender>()
                .HasMany(a => a.Contacts)
                .WithOne(b => b.Lender);

 

            builder.Entity<Liabilities_LoanProfiles>()
                .HasKey(ab => new { ab.LiabilityId, ab.LoanProfileId });
            builder.Entity<Liabilities_LoanProfiles>()
                .HasOne(ab => ab.Liability)
                .WithMany(b => b.LoanProfiles)
                .HasForeignKey(ab => ab.LiabilityId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.Entity<Liabilities_LoanProfiles>()
                .HasOne(ab => ab.LoanProfile)
                .WithMany(b => b.Liabilities)
                .HasForeignKey(ab => ab.LoanProfileId)
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
