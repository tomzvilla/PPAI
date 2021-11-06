using PPAI.Entidades;
using PPAI.RepositoriosBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Servicios
{
    public class ExposicionServicio
    {
        private ExposicionRepositorio exposicionRepositorio;


        public ExposicionServicio()
        {
            exposicionRepositorio = new ExposicionRepositorio();
        }

        public List<Exposicion> obtenerExposiciones(int id) {
            return exposicionRepositorio.obtenerExposiciones(id);
        }


    }
}
