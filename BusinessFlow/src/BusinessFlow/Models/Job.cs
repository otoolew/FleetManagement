using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessFlow.Models
{
    public class Job
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "ECMS")]
        //[StringLength(100, MinimumLength = 5, ErrorMessage = "VIN must be between 5 and 100 characters long.")]
        [Column(TypeName = "varchar(50)")]
        public string ECMS { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Contractor")]
        [Column(TypeName = "varchar(50)")]
        public string Contractor { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "County")]
        [Column(TypeName = "varchar(50)")]
        public string County { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Location")]
        [Column(TypeName = "varchar(50)")]
        public string Location { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Bid / Let Date")]
        [Column(TypeName = "varchar(50)")]
        public string BidLetDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Quote Date")]
        [Column(TypeName = "varchar(50)")]
        public string QuoteDate { get; set; }

        //public virtual ICollection<Vehicle> Vehicles { get; set; }
        //public virtual ICollection<Worker> Workers { get; set; }
        //public virtual ICollection<Material> Materials { get; set; }
        //public List<Part> Parts { get; set; }
    }
}
