using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc_lab.Models
{
    [Table("t_contacto")]
    public class Contacto
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int ID { get; set; }

        [Required]
        [Display(Name="Name")]
        [Column("name")]
        public String Nombre{ get; set; }

        [Required]
        [Display(Name="LastName")]
        [Column("lastname")]
        public String Apellido{ get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name="Email")]
        [Column("email")]
        public String Email{ get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name="Phone")]
        [Column("phone")]
        public int Telefono{ get; set; }

        [Required]
        [Display(Name="Subject")]
        [Column("subject")]
        public String Titulo{ get; set; }

        [Required]
        [Display(Name="Message")]
        [Column("message")]
        public String Mensaje{ get; set; }

        [NotMapped]
        [Display(Name="Output")]
        public String Respuesta { get; set; }
    }
    }