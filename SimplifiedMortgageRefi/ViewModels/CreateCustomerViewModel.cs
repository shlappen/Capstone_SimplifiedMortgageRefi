using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimplifiedMortgageRefi.Models
{
    public class CreateCustomerViewModel
    {
        public Customer Customer { get; set; }
        public Property Property { get; set; }
        public Address Address { get; set; }
        public LoanProfile LoanProfile { get; set; }

    }
}
