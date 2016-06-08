using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WorkFlowManager.Models
{
    public class Job
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "ECMS")]
        //[StringLength(100, MinimumLength = 5, ErrorMessage = "VIN must be between 5 and 100 characters long.")]
        public string ECMS { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Contractor")]
        public string Contractor { get; set; }

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

        public virtual ICollection<Vehicle> Vehicles { get; set; }
        public virtual ICollection<Worker> Workers { get; set; }
        public virtual ICollection<Material> Materials { get; set; }
        //public List<Part> Parts { get; set; }
    }
}
