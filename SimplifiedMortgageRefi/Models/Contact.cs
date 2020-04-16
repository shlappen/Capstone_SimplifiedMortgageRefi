using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SimplifiedMortgageRefi.Models
{
    public class Contact
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public string Result { get; set; }

        public DateTime DateTime { get; set; }

        [ForeignKey("Application")]
        public int ApplicationId { get; set; }
        public Application Application { get; set; }

        [ForeignKey("Lender")]
        [Display(Name = "Lender")]
        public int LenderId { get; set; }

        public Lender Lender { get; set; }
    }
}
