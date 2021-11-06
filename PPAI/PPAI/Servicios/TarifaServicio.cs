using PPAI.Entidades;
using PPAI.RepositoriosBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Servicios
{
    public class TarifaServicio
    {
        private TarifaRepositorio tarifaRepositorio;


        public TarifaServicio()
        {
            tarifaRepositorio = new TarifaRepositorio();
        }

        public List<Tarifa> obtenerTarifas(int id) {
            return tarifaRepositorio.obtenerTarifas(id);
        }

        public Tarifa obtenerTarifa(int entrada, int visita)
        {
            return tarifaRepositorio.obtenerTarifa(entrada, visita);
        }
    }
}
