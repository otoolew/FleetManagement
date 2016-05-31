using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WorkFlowManager.Models
{
    public class Bid
    {
        public long Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "ECMS")]
        public string ECMS { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "County")]
        public string County { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Location")]
        public string Location { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Bid / Let Date")]
        public string BidLetDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Quote Date")]
        public string QuoteDate { get; set; }
    }
}
