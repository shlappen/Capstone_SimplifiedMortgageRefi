using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimplifiedMortgageRefi.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        [Required(ErrorMessage = "Street is required")]
        public string Street { get; set; }
        [Required(ErrorMessage = "City is required")]
        public string City { get; set; }

        
        [Display(Name = "State")]
        [Required(ErrorMessage = "State is required")]
        public int StateId { get; set; }
        public USState State { get; set; }
        
        [Display(Name = "Zip Code")]
        [Required(ErrorMessage = "Zip Code is required")]
        public string ZipCode { get; set; }
    }
}