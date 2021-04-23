using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApiAutor.Models
{
    public class Autor
    {
        public int AutorId { get; set; }

        [Required]
        public string Apellido { get; set; }

        [Required]
        public string Nombre { get; set; }

        public string Ciudad { get; set; }
    }
}
