using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SimplifiedMortgageRefi.Models
{
    public class Application
    {

        public int Id { get; set; }

        public bool IsEligible { get; set; }

        public int PropertyId { get; set; }
        public Property Property { get; set; }

        public DateTime ApplicationStartDate { get; set; }

        public ICollection<LoanProfile> LoanProfiles { get; set; }
        public ICollection<Contact> Contacts {get; set;}
        public ICollection<Applications_Customers> Customers { get; set; }

    }
}
