using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimplifiedMortgageRefi.Models
{
    public class CreateCustomerViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int AssessedValue { get; set; }
        public float MonthlyIncome { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }

        public int StateId { get; set; }
        public int PurposeId { get; set; }

        public int CreditScore { get; set; }

        public IEnumerable<USState> States { get; set; }
    }
}
