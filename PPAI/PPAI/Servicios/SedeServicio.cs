using PPAI.Entidades;
using PPAI.RepositoriosBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Servicios
{
    public class SedeServicio
    {
        private SedeRepositorio sedeRepositorio;


        public SedeServicio()
        {
            sedeRepositorio = new SedeRepositorio();
        }

        public Sede obtenerSede(int id) {
            return sedeRepositorio.obtenerSede(id);
        }
    }
}
