using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimplifiedMortgageRefi.Models
{
    public class Application
    {

        public int Id { get; set; }

        public bool IsEligible { get; set; }

        public DateTime ApplicationStartDate { get; set; }

        public ICollection<LoanProfile> LoanProfiles { get; set; }
        public ICollection<Contact> Contacts {get; set;}
        public ICollection<Applications_Customers> Customers { get; set; }

    }
}
