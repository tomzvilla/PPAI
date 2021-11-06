using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class Empleado
    {
        public string apellido { get; set; }
        public string nombre { get; set; }
        public int codigoValidacion { get; set; }
        public int cuit { get; set; }
        public int dni { get; set; }

        public String domicilio { get; set; }
        public DateTime? fechaIngreso { get; set; }
        public DateTime? fechaNacimiento { get; set; }
        public String email { get; set; }
        public int sexo { get; set; }
        public int telefono { get; set; }
        //public Cargo cargo { get; set; }
        //public Horario horario { get; set; }
        public Sede sede { get; set; }


        public Sede getSede()
        {
            return this.sede;
        }


    }
}
