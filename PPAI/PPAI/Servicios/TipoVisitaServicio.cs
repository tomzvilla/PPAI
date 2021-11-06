using PPAI.Entidades;
using PPAI.RepositoriosBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Servicios
{
    public class TipoVisitaServicio
    {
        private TipoVisitaRepositorio tipoVisitaRepositorio;


        public TipoVisitaServicio()
        {
            tipoVisitaRepositorio = new TipoVisitaRepositorio();
        }

        public List<TipoVisita> getTipoVisitas() {
            return tipoVisitaRepositorio.getTipoVisitas();
        }
    }
}
