using System.ComponentModel.DataAnnotations.Schema;

namespace SimplifiedMortgageRefi.Models
{
    public class Income
    {
        public int Id { get; set; }
        public string Source { get; set; }
        public bool IsIncluded { get; set; }
        public decimal MonthlyGross { get; set; }

        [ForeignKey("Loan Profile")]
        public int LoanProfileId { get; set; }
        public LoanProfile LoanProfile { get; set; }
    }
}