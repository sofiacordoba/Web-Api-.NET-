using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWMedicos.Models
{
    public class Medico
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Especialidad { get; set; }
        public int NroMatricula { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Ciudad { get; set; }
    }
}
