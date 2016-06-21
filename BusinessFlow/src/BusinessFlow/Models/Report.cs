using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessFlow.Models
{
    public class Report
    {
        public long Id { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Report Date")]
        [Column(TypeName = "varchar(50)")]
        public string ReportDate { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Vehicle")]
        [Column(TypeName = "varchar(50)")]
        public string VehicleID { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Comments")]
        [Column(TypeName = "varchar(50)")]
        public string Comment { get; set; }

    }
}
