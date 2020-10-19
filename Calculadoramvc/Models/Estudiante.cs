using System;
using System.ComponentModel.DataAnnotations;

namespace mvc_lab.Models{
    public class Estudiante{

        [Required]
        public String Name{ get; set; }

        [Required]
        public String Last_name{ get; set; }

        [Required]
        public String Subject{ get; set; }

        [Display(Name="Answer")]
        public String Answer{ get; set; }
        
    }
} 