using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessFlow.Models
{
    public class Part
    {
        public long Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Serial Number")]
        [Column(TypeName = "varchar(50)")]
        public string Serial { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Name")]
        [Column(TypeName = "varchar(50)")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Brand")]
        [Column(TypeName = "varchar(50)")]
        public string Brand { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Model")]
        [Column(TypeName = "varchar(50)")]
        public string Model { get; set; }

        [Required]   
        [DataType(DataType.Text)]
        [Display(Name = "Type")]
        [Column(TypeName = "varchar(50)")]
        public string Type { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Supplier")]
        [Column(TypeName = "varchar(50)")]
        public string Supplier { get; set; }
    }
}
