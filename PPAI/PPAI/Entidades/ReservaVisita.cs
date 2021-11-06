using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class ReservaVisita
    {
        public int cantidadAlumnos { get; set; }
        public int cantidadAlumnosConfirmada { get; set; }
        public int duracionEstimada { get; set; }
        public int numeroReserva { get; set; }
        public DateTime? fechaHoraCreacion { get; set; }
        public DateTime fechaHoraReserva { get; set; }
        public DateTime? horaFinReal { get; set; }
        public DateTime? horaInicioReal { get; set; }
        public Empleado empleadoCreo { get; set; }
        public Exposicion exposicion { get; set; }
        public Sede sede { get; set; }


        //public Escuela escuela { get; set; }
        //public List<AsignacionGuia> asignacionGuia { get; set; }


        public bool sonParaFechaHoraSede(int id_sede, DateTime fechaActual)
        {
            //Este mensaje, verifica si una reserva esta asociada a la sede
            //que se le paso por parametro, y si es de la fecha que se le paso
            //por parametro. Devuelve un valor booleano. Se considera que
            //si la reserva es de una fecha, el visitante permanece_todo el dia
            if (this.sede.id_sede == id_sede)
            {
                if(this.fechaHoraReserva.Date == fechaActual.Date)
                {
                    return true;
                }
            }
            return false;
        }

/*
    def conocerAsignacionGuia(self):
        pass

    def conocerCambioEstado(self):
        pass

    def conocerEmpleado(self):
        pass

    def conocerEscuela(self):
        pass

    def conocerExposicion(self):
        pass

    def conocerSede(self):
        pass
         
         
         */





    }
}
