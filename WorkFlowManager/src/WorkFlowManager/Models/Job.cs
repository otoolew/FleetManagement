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
        [Display(Name = "Number")]
        //[StringLength(100, MinimumLength = 5, ErrorMessage = "VIN must be between 5 and 100 characters long.")]
        public string Number { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Description")]
        //[StringLength(100, MinimumLength = 5, ErrorMessage = "Name must be between 5 and 100 characters long.")]
        public string Description { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Quantity")]
        //[StringLength(50, MinimumLength = 3, ErrorMessage = "Make must be between 3 and 50 characters long.")]
        public string Quantity { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Price")]
        //[StringLength(50, MinimumLength = 3, ErrorMessage = "Model must be between 3 and 50 characters long.")]
        public string Price { get; set; }

        [Required]
        [DataType(DataType.Currency)]     
        [Display(Name = "Amount")]
        public string Amount { get; set; }

        //public List<Part> Parts { get; set; }
    }
}
