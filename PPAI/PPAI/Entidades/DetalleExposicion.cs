using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class DetalleExposicion
    {
        public string LugarAsignado { get; set; }
        public Obra obra { get; set; }
        //public Pared pared {get; set;}

        public Obra conocerObra()
        {
            // Devuelve el puntero a la obra
            return this.obra;
        }
        public int calcularDuracionObra()
        {
            // Envia un mensaje a la obra, para obtener su duracion resumida
            return this.obra.getDuracionResumida();
        }
    }
}
