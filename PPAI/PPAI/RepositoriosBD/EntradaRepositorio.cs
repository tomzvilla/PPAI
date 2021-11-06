using PPAI.Entidades;
using PPAI.RepositoriosBD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.RepositoriosBD
{
    public class EntradaRepositorio
    {
        public List<Entradas> obtenerEntradas()
        {
            var entradas = new List<Entradas>();
            var sentenciaSQL = $"SELECT * FROM entrada";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSQL);
            foreach(DataRow fila in tabla.Rows)
            {   
                var entrada = MapearEntrada(fila);
                entradas.Add(entrada);
            }
            return entradas;
        }

        private Entradas MapearEntrada(DataRow fila)
        {
            var entrada = new Entradas();
            entrada.FechaVenta = Convert.ToDateTime(fila["fec_venta"]);
            entrada.Monto = Convert.ToInt32(fila["monto"]);
            entrada.Numero = Convert.ToInt32(fila["numero"]);
            var tarifa = new Tarifa
            {
                id_tarifa = Convert.ToInt32(fila["id_tarifa"])
            };
            entrada.tarifa = tarifa;
            var sede = new Sede
            {
                id_sede = Convert.ToInt32(fila["id_sede"])
            };
            entrada.sede = sede;
            return entrada;

        }
    }
}
