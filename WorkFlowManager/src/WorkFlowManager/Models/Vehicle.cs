using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WorkFlowManager.Models
{
    public class Vehicle
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "VIN")]
        //[StringLength(100, MinimumLength = 5, ErrorMessage = "VIN must be between 5 and 100 characters long.")]
        public string VIN { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Name")]
        //[StringLength(100, MinimumLength = 5, ErrorMessage = "Name must be between 5 and 100 characters long.")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Make")]
        //[StringLength(50, MinimumLength = 3, ErrorMessage = "Make must be between 3 and 50 characters long.")]
        public string Make { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Model")]
        //[StringLength(50, MinimumLength = 3, ErrorMessage = "Model must be between 3 and 50 characters long.")]
        public string Model { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Range(1940,2100, ErrorMessage = "Please enter a valid Year")]
        [Display(Name = "Year")]
        public string Year { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Type")]
        //[StringLength(50, MinimumLength = 3, ErrorMessage = "Type must be between 3 and 50 characters long.")]
        public string Type { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "License")]
        //[StringLength(50, MinimumLength = 10, ErrorMessage = "License must be between 10 and 50 characters long.")]
        public string License { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Registration")]
        //[StringLength(50, MinimumLength = 10, ErrorMessage = "License must be between 10 and 50 characters long.")]
        public string Registration { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Engine")]
        //[StringLength(50, MinimumLength = 10, ErrorMessage = "License must be between 10 and 50 characters long.")]
        public string Engine { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Transmission")]
        //[StringLength(50, MinimumLength = 10, ErrorMessage = "License must be between 10 and 50 characters long.")]
        public string Transmission { get; set; }

        //public List<Part> Parts { get; set; }
    }
}
