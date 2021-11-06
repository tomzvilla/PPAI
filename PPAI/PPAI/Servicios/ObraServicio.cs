using PPAI.Entidades;
using PPAI.RepositoriosBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Servicios
{
    public class ObraServicio
    {
        private ObraRepositorio obraRepositorio;


        public ObraServicio()
        {
            obraRepositorio = new ObraRepositorio();
        }

        public Obra obtenerObra(int id) {
            return obraRepositorio.obtenerObra(id);
        }
    }
}
