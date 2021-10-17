using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI.Entidades;


namespace PPAI.Entidades
{
    public class Entradas
    {
        public DateTime FechaVenta { get; set; }
        
        public DateTime HoraVenta { get; set; }

        public double Monto { get; set; }
        public int Numero { get; set; }
        
        public Tarifa tarifa { get; set; }
        public Sede sede { get; set; }

        



        //def getNumero(self):
        //return self.numero
        
        //     def conocerSede(self):
        //return self.sede.mostrarNombre()

        //def conocerTarifa(self):
        //    return self.tarifa

        //def esDeFechayHoraSede(self, sede, fecha):
        //    if self.sede.mostrarNombre() == sede.mostrarNombre():
        //    if self.fechaVenta == fecha:
        //        return True
        //return False
         
         
    }
}
