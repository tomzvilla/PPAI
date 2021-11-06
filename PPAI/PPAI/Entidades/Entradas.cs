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

        public bool esDeFechayHoraSede(int sedeActual, DateTime fechaActual)
        {
            //Este mensaje, verifica si una entrada esta asociada a la sede
            //que se le paso por parametro, y si es de la fecha que se le paso
            //por parametro. Devuelve un valor booleano

            if (this.sede.id_sede == sedeActual)
            {
                if(this.FechaVenta.Date == fechaActual.Date)
                {
                    return true;
                }
            }
            return false;
        }

        public int getNumero()
        {
            // Devuelve el numero de la entrada
            return this.Numero;
        }





    }
}
