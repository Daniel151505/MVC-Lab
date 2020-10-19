using System;
using System.ComponentModel.DataAnnotations;

namespace mvc_lab.Models
{
    public class Contacto
    {

        [Required]
        [Display(Name="Name")]
        public String Nombre{ get; set; }

        [Required]
        [Display(Name="LastName")]
        public String Apellido{ get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name="Email")]
        public String Email{ get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name="Phone")]
        public int Telefono{ get; set; }

        [Required]
        [Display(Name="Subject")]
        public String Titulo{ get; set; }

        [Required]
        [Display(Name="Message")]
        public String Mensaje{ get; set; }

        [Required]
        [Display(Name="Output")]
        public String Respuesta { get; set; }
    }
}