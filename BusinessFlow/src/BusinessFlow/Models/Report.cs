using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BusinessFlow.Models
{
    public class Report
    {
        public long Id { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Report Date")]
        public string ReportDate { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Vehicle")]
        public string VehicleID { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Comments")]
        public string Comment { get; set; }

    }
}
