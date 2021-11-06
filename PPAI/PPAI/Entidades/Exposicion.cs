using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class Exposicion
    {
        public int id_exposicion { get; set; }
        public string Nombre { get; set; }
        public DateTime? FechaFin { get; set; }
        public DateTime? FechaFinReplanificada { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaReplanificada { get; set; }
        public DateTime? HoraApertura { get; set; }
        public DateTime? HoraCierre { get; set; }
        //public TipoExposicion tipoExposicion { get; set; }
        public Empleado empleadoCreo { get; set; }
        //public PublicoDestino publicoDestino { get; set; }
        public List<DetalleExposicion> detalleExposicion { get; set; }

        public bool esVigente(DateTime fechaActual)
        {
            //Recibe como parametro una fecha. Si la exposicion nunca se replanifico, utiliza el atributo
            //fechaFin para calcular la vigencia. Caso contrario, se utiliza la fechaFinReplanificada
            //devuelve un valor booleano, para saber si esVigente o no
            if (this.FechaFinReplanificada == null)
            {
                if(this.FechaFin > fechaActual)
                {
                    return true;
                }
            }else if(this.FechaFinReplanificada > fechaActual)
            {
                return true;
            }
            return false;
        }

        public int calcularDuracionObrasExpuestas()
        {
            //Este metodo, envia mensajes a todos los detalles exposicion de una exposicion en particular
            //y calcula la duracion del recorrido de una sola exposicion.
            int i = 0;
            int duracionExposicion = 0;
            while(i < this.detalleExposicion.Count)
            {
                duracionExposicion += this.detalleExposicion[i].calcularDuracionObra();
                i += 1;
            }
            return duracionExposicion;
        }

    }
}
