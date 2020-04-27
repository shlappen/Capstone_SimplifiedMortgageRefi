using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimplifiedMortgageRefi.Models
{
    public class Liability
    {
        public int Id { get; set; }

        public string LenderName { get; set; }

        public double Balance { get; set; }

        public double Payment { get; set; }

        public bool IsIncludedOnApp { get; set; }
        public Liability()
        {
            IsIncludedOnApp = true;
        }

        public bool IsConsolidated { get; set; }

        public int ApplicationId { get; set; }
        public Application Application { get; set; }

        public virtual ICollection<Liabilities_LoanProfiles> LoanProfiles { get; set; }

        [Display(Name = "Liability Type")]
        public int LiabilityTypeId { get; set; }
        public LiabilityType LiabilityType { get; set; }

        [NotMapped]
        public IEnumerable<LiabilityType> LiabilityTypes { get; set; }

    }
}