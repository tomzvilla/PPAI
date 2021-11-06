using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class Tarifa
    {
        public int id_tarifa { get; set; }
        public DateTime? fechaFinVigencia { get; set; }
        public DateTime? fechaInicioVigencia { get; set; }
        public int Monto { get; set; }
        public int MontoAdicionalGuia { get; set; }
        public TipoEntrada tipoEntrada { get; set; }
        public TipoVisita tipoVisita { get; set; }
        
        
        public TipoEntrada conocerEntrada()
        {
            return this.tipoEntrada;
        }

        public TipoVisita conocerVisita()
        {
            return this.tipoVisita;
        }
        
        public Tarifa buscarTarifasVigentes(DateTime? fecha)
        {
            // Mensaje que verifica si la fecha pasada como parametro es anterior a la fecha fin de vigencia,
            // es decir, verifica si la tarifa es vigente.
            if (this.fechaFinVigencia > fecha)
                return this;
            else
                return null;
        }

        public List<string> buscarDatosTarifasVigentes()
        {
            // Devuelve un array con el nombre del tipo Entrada y tipo Visita
            var listado = new List<string>();
            listado.Add(this.tipoEntrada.mostrarNombre());
            listado.Add(this.tipoVisita.mostrarNombre());
            return listado;
        }



    }
}
