﻿using SimplifiedMortgageRefi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimplifiedMortgageRefi.ViewModels
{
    public class IndexCustomerViewModel
    {
        public Customer Customer { get; set; }
        public Property Property { get; set; }
        public IEnumerable<LoanProfile> LoanProfiles { get; set; }
        public Application Application { get; set; }
        public IEnumerable<Liability> Liabilities { get; set; }
        public Liability Liability { get; set; }
    }
}
