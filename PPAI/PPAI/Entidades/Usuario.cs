using PPAI.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{

    public class Usuario{
        public int Caducidad { get; set; }
        public string Contrasenia { get; set; }
        public string Nombre { get; set; }
        public Empleado empleado { get; set; }

        public Empleado obtenerEmpleadoLogueado()
        {
            return empleado;
        }

        public string obtenerNomUsuario()
        {
            return this.Nombre;
        }
    }

    
}
