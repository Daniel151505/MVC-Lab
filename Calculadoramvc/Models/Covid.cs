using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc_lab.Models
{
    [Table("t_covidpc1")]
    public class Covid
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
        [Display(Name="District")]
        [Column("district")]
        public String Distrito{ get; set; }

        [Required]
        [Display(Name="Bank")]
        [Column("bank")]
        public String Banco{ get; set; }

        [Required]
        [Display(Name="Age")]
        [Column("age")]
        public int Edad{ get; set; }

        [Required]
        [Display(Name="Genre")]
        [Column("genre")]
        public String Genero{ get; set; }

        [Display(Name="Author")]
        [Column("author")]
        public String Autor{ get; set; }

        [NotMapped]
        [Display(Name="Output")]
        public String Respuesta { get; set; }
    }
}
