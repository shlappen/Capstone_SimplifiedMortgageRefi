using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SimplifiedMortgageRefi.Models
{
    public class LoanProfile
    {
        public int Id { get; set; }

        public int Term { get; set; }

        public string Originator { get; set; } //this should be the Customer or the Lender
        public double Rate { get; set; }

        public double LoanAmount { get; set; }

        public int EstimatedValue { get; set; }

        public int CreditScore { get; set; }

        public int ApplicationId { get; set; }
        public Application Application { get; set; }

        public bool IsCashOut { get; set; }

        public bool IsCurrentMortgage { get; set; }

        public ICollection<Income> Incomes { get; set; }
        public ICollection<Liability> Liabilities { get; set; }

        public double DebtToIncome { get; set; }
        public double LoanToValue { get; set; }

        public int PurposeId { get; set; }
        public Purpose Purpose { get; set; }

        [NotMapped]
        public IEnumerable<Purpose> Purposes { get; set; }

    }
}
