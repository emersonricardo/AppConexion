using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AlumnosBD.Models
{
    public class AlumnosModel
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public string Direccion { get; set; }

        public string Email { get; set; }
        [Required]
        public string Telefono { get; set; }


    }
     
}