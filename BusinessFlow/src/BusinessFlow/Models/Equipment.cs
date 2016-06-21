using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessFlow.Models
{
    public class Equipment
    {
        public long Id { get; set; }
       
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Name")]
        [Column(TypeName = "varchar(50)")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Make")]
        [Column(TypeName = "varchar(50)")]
        public string Make { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Model")]
        [Column(TypeName = "varchar(50)")]
        public string Model { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Year")]
        [Column(TypeName = "varchar(50)")]
        public string Year { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Type")]
        [Column(TypeName = "varchar(50)")]
        public string Type { get; set; }
    }
}
