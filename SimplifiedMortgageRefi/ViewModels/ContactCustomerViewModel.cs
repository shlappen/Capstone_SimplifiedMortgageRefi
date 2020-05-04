using SimplifiedMortgageRefi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimplifiedMortgageRefi.ViewModels
{
    public class ContactCustomerViewModel
    {
        public Application Application { get; set; }

        public List<Customer> Customers { get; set; }

        public List<Contact> Contacts { get; set; }
        public Contact Contact { get; set; }
        public Customer Customer { get; set; }
        public Lender Lender { get; set; }

        public Property Property { get; set; }
        public IEnumerable<LoanProfile> LoanProfiles { get; set; }

        public IEnumerable<Liability> Liabilities { get; set; }
        public Liability Liability { get; set; }
    }
}
