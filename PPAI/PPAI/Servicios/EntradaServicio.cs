using PPAI.Entidades;
using PPAI.RepositoriosBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Servicios
{
    public class EntradaServicio
    {
        private EntradaRepositorio entradaRepositorio;


        public EntradaServicio()
        {
            entradaRepositorio = new EntradaRepositorio();
        }

        public List<Entradas> obtenerEntradas() {
            return entradaRepositorio.obtenerEntradas();
        }

        public void registrarEntradas(List<Entradas> entradasVendidas)
        {
            entradaRepositorio.registrarEntradas(entradasVendidas);
        }
    }
}
