using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessFlow.Models
{
    public class Worker
    {
        public long Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "First Name")]
        [Column(TypeName = "varchar(50)")]
        public string FirstName { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Last Name")]
        [Column(TypeName = "varchar(50)")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Job Title")]
        [Column(TypeName = "varchar(50)")]
        public string JobTitle { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Hourly Rate")]
        [Column(TypeName = "varchar(50)")]
        public string HourlyRate { get; set; }
        
        [DataType(DataType.Text)]
        [Display(Name = "License")]
        [Column(TypeName = "varchar(50)")]
        public string License { get; set; }
    }
}
