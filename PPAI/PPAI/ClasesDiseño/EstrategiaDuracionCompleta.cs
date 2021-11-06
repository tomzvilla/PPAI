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
