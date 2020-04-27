using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimplifiedMortgageRefi.Models
{
    public class Property
    {
        public int Id { get; set; }

        public int AddressId {get; set; }
        public Address Address { get; set; }

        public int AssessedValue { get; set; }

        public double MortgageBalance { get; set; }
        public double OriginalMortgageBalance { get; set; }
        public double MonthlyPayment { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-yyyy}", ApplyFormatInEditMode = true)]
        
        public DateTime OriginationDate { get; set; }

        public double Rate { get; set; }

        public int Term { get; set; }

        public double MonthlyPropertyTax { get; set; }

        public double  MonthlyHOIPremium { get; set; }

        public ICollection<Customers_Properties> Customers { get; set; }
        public ICollection<Application> Applications { get; set; }

        [ForeignKey("PropertyType")]
        [Display(Name = "Property Type")]
        public int PropertyTypeId { get; set; }
        public PropertyType PropertyType { get; set; }

        [NotMapped]
        public IEnumerable<PropertyType> PropertyTypes { get; set; }


        [ForeignKey("OccupancyType")]
        [Display(Name = "Occupancy Type")]
        public int OccupancyTypeId { get; set; }
        public OccupancyType OccupancyType { get; set; }

        [NotMapped]
        public IEnumerable<OccupancyType> OccupancyTypes { get; set; }

    }
}