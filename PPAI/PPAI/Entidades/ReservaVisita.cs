using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    class ReservaVisita
    {
        public int cantidadAlumnos { get; set; }
        public int cantidadAlumnosConfirmada { get; set; }
        public int duracionEstimada { get; set; }
        public int numeroReserva { get; set; }
        public DateTime? fechaHoraCreacion { get; set; }
        public DateTime? fechaHoraReserva { get; set; }
        public DateTime? horaFinReal { get; set; }
        public DateTime? horaInicioReal { get; set; }
        public EmpleadoCreo empleadoCreo { get; set; }
        public Exposicion exposicion { get; set; }
        public Sede sede { get; set; }
        public Escuela escuela { get; set; }
        public List<AsignacionGuia> asignacionGuia { get; set; }
        /*
             def sonParaFechaHoraSede(self, sede, fecha):
        if self.sede.mostrarNombre() == sede.mostrarNombre():
            if self.fechaHoraReserva == fecha:
                return True
        return False

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
