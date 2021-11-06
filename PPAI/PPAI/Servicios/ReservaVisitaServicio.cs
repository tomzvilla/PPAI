using PPAI.Entidades;
using PPAI.RepositoriosBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Servicios
{
    public class ReservaVisitaServicio
    {
        private ReservaVisitaRepositorio reservaVisitaRepositorio;


        public ReservaVisitaServicio()
        {
            reservaVisitaRepositorio = new ReservaVisitaRepositorio();
        }

        public List<ReservaVisita> obtenerReservas() {
            return reservaVisitaRepositorio.obtenerReservas();
        }
    }
}
