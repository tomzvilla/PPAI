using PPAI.Entidades;
using PPAI.RepositoriosBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Servicios
{
    public class DetalleExposicionServicio
    {
        private DetalleExposicionRepositorio detalleExposicionRepositorio;


        public DetalleExposicionServicio()
        {
            detalleExposicionRepositorio = new DetalleExposicionRepositorio();
        }

        public List<DetalleExposicion> obtenerDetalleExposiciones(int id) {
            return detalleExposicionRepositorio.obtenerDetalleExposiciones(id);
        }


    }
}
