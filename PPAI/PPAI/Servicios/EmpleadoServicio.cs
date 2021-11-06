using PPAI.Entidades;
using PPAI.RepositoriosBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Servicios
{
    public class EmpleadoServicio
    {
        private EmpleadoRepositorio empleadoRepositorio;


        public EmpleadoServicio()
        {
            empleadoRepositorio = new EmpleadoRepositorio();
        }

        public Empleado obtenerEmpleado(int dni) {
            return empleadoRepositorio.obtenerEmpleado(dni);
        }
    }
}
