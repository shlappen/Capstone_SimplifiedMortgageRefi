using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimplifiedMortgageRefi.Models
{
    public class Liabilities_LoanProfiles
    {
        public int LiabilityId { get; set; }

        public Liability Liability { get; set; }

        public int LoanProfileId { get; set; }

        public LoanProfile LoanProfile { get; set; }

    }
}
