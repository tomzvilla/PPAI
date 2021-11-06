using PPAI.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.ClasesDiseño
{
    interface IEstrategiaCalcularDuracionExposicion
    {
        int calcularDuracionAExposicionesVigentes(DateTime fechaActual, List<Exposicion> expos);

    }

}
