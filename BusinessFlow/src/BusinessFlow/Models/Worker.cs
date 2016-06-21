using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BusinessFlow.Models
{
    public class Worker
    {
        public long Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Job Title")]
        public string JobTitle { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Hourly Rate")]
        public string HourlyRate { get; set; }
        
        [DataType(DataType.Text)]
        [Display(Name = "License")]
        public string License { get; set; }
    }
}
