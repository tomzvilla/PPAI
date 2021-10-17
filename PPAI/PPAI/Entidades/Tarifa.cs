using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    class Tarifa
    {
        public DateTime? fechaFinVigencia { get; set; }
        public DateTime? fechaInicioVigencia { get; set; }
        public int Monto { get; set; }
        public int MontoAdicionalGuia { get; set; }
        public TipoEntrada tipoEntrada { get; set; }
        public TipoVisita tipoVisita { get; set; }
        
        
        /*
             def conocerEntrada(self):
        return self.tipoEntrada.mostrarNombre()
    def conocerVisita(self):
        return self.tipoVisita.mostrarNombre()

    def mostrarMontosVigentes(self, fecha):
        if self.fechaFinVigencia > fecha:
            return self
        else:
            return []
         */



    }
}
