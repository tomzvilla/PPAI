using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class TipoVisita
    {
        public string Nombre { get; set; }
        public int id_tipo_visita { get; set; }

        public string mostrarNombre()
        {
            return this.Nombre;
        }
    }
}
