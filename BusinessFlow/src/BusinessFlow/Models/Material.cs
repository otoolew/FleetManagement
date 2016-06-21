using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessFlow.Models
{
    public class Material
    {
        public long Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Item Number")]
        //[StringLength(100, MinimumLength = 5, ErrorMessage = "VIN must be between 5 and 100 characters long.")]
        [Column(TypeName = "varchar(50)")]
        public string ItemNumber { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Description")]
        [Column(TypeName = "varchar(50)")]
        public string Description { get; set; } 

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Bin / Location")]
        [Column(TypeName = "varchar(50)")]
        public string BinLocation { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Price")]
        [Column(TypeName = "varchar(50)")]
        public string Price { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Quantity")]
        [Column(TypeName = "varchar(50)")]
        public string Quantity { get; set; }

    }
}
