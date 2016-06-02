using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WorkFlowManager.Models
{
    public class Material
    {
        public long Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Item Number")]
        //[StringLength(100, MinimumLength = 5, ErrorMessage = "VIN must be between 5 and 100 characters long.")]
        public string ItemNumber { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Description")]
        public string Description { get; set; } 

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Bin / Location")]
        public string BinLocation { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Price")]
        public string Price { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Quantity")]
        public string Quantity { get; set; }

    }
}
