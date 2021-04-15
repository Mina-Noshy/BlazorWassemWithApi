using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyWebModels.Models
{
    public class Employee
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string department { get; set; }

        [Required]
        public string phone { get; set; }

        [Required]
        public string job { get; set; }
    }
}
