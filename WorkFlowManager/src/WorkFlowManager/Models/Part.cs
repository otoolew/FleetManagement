using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WorkFlowManager.Models
{
    public class Part
    {
        public long Id { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Serial Number")]
        private string Serial { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Name")]
        private string Name { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Model Name")]
        private string Model { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Type")]
        private string Type { get; set; }
    }
}
