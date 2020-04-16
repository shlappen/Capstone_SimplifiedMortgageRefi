using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SimplifiedMortgageRefi.Models
{
    public class Customer
    {
        public int Id { get; set; }


        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Name is Required")]
        public string FirstName { get; set; }


        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Name is Required")]
        public string LastName { get; set; }


        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }

        public ICollection<Applications_Customers> Applications { get; set; }
        public ICollection<Customers_Properties> Properties {get; set; }

    }
}
