using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class TipoEntrada
    {
        public int id_tipo_entrada { get; set; }
        public string Nombre { get; set; }


        public string mostrarNombre()
        {
            return this.Nombre;
        }

    }
}
