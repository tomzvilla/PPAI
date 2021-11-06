using PPAI.Entidades;
using PPAI.RepositoriosBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Servicios
{
    public class TipoEntradaServicio
    {
        private TipoEntradaRepositorio tipoEntradaRepositorio;


        public TipoEntradaServicio()
        {
            tipoEntradaRepositorio = new TipoEntradaRepositorio();
        }

        public List<TipoEntrada> getTipoEntradas() {
            return tipoEntradaRepositorio.getTipoEntradas();
        }
    }
}
