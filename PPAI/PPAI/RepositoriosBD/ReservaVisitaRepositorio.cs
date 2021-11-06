using PPAI.Entidades;
using PPAI.RepositoriosBD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.RepositoriosBD
{
    public class ReservaVisitaRepositorio
    {
        public List<ReservaVisita> obtenerReservas()
        {
            var reservas = new List<ReservaVisita>();
            var sentenciaSQL = $"SELECT * FROM reserva_visita";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSQL);
            foreach(DataRow fila in tabla.Rows)
            {   
                var reserva = MapearReserva(fila);
                reservas.Add(reserva);
            }
            return reservas;
        }

        private ReservaVisita MapearReserva(DataRow fila)
        {
            var reserva = new ReservaVisita();
            reserva.cantidadAlumnos = Convert.ToInt32(fila["cantidad_alumnos"]);
            reserva.cantidadAlumnosConfirmada = Convert.ToInt32(fila["cantidad_alumnos_confirmada"]);
            reserva.duracionEstimada = Convert.ToInt32(fila["duracion_estimada"]);
            reserva.fechaHoraReserva = Convert.ToDateTime(fila["fec_hora_reserva"]);
            reserva.exposicion = new Exposicion
            {
                id_exposicion = Convert.ToInt32(fila["id_exposicion"]),
            };
            reserva.sede = new Sede
            {
                id_sede = Convert.ToInt32(fila["id_sede"])
            };
            return reserva;
        

        }
    }
}
