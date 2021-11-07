using PPAI.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.ClasesDiseño
{
    public class EstrategiaDuracionCompleta : IEstrategiaCalcularDuracionExposicion
    {
        public int calcularDuracionAExposicionesVigentes(DateTime fechaActual, List<Exposicion> exposiciones)
        {
            // Metodo polimorfico implementado de la interfaz IEstrategiaCalcularDuracionExposicion
            // Es un loop que a cada exposicion le pregunta si esta vigente y si lo está
            // llama al metodo calcularDuracionObrasExpuestas que devuelve un int representando el tiempo
            // En minutos que dura recorrer todas las obras de la exposicion
            int i = 0;
            int duracionVisita = 0;
            while (i < exposiciones.Count())
            {
                var vigencia = exposiciones[i].esVigente(fechaActual);
                if (vigencia)
                {
                    duracionVisita += exposiciones[i].calcularDuracionObrasExpuestas();
                }
                i += 1;
            }
            return duracionVisita;
        }

    }
}
