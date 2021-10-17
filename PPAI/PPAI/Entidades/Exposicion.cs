using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    class Exposicion
    {
        public string Nombre { get; set; }
        public DateTime? FechaFin { get; set; }
        public DateTime? FechaFinReplanificada { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaReplanificada { get; set; }
        public DateTime? HoraApertura { get; set; }
        public DateTime? HoraCierre { get; set; }
        public TipoExpo tipoExposicion { get; set; }
        public EmpleadoCreo empleadoCreo { get; set; }
        public PublicoDestino publicoDestino { get; set; }
        public List<DetalleExposicion> detalleExposicion { get; set; }
            


        /*
         
             def esVigente(self, fecha):
        if self.fechaFinReplanificada == '':
            if self.fechaFin > fecha:
                return True
        elif self.fechaFinReplanificada > fecha:
            return True
        return False


    def calcularDuracionObrasExpuestas(self):
        i=0
        duracionExposicion = 0
        while i < len(self.detalleExposicion):
            duracionExposicion+= self.detalleExposicion[i].calcularDuracionObra()
            i+=1
        return duracionExposicion     
         */

    }
}
