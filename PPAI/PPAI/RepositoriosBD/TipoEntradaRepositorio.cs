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
    public class TipoEntradaRepositorio
    {
        public List<TipoEntrada> getTipoEntradas()
        {
            var tipoEntradas = new List<TipoEntrada>();
            var sentenciaSQL = $"SELECT * FROM tipo_entrada";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSQL);
            foreach(DataRow fila in tabla.Rows)
            {
                var tipoEntrada = MapearTipoEntrada(fila);
                tipoEntradas.Add(tipoEntrada);
            }
            return tipoEntradas;
        }

        private TipoEntrada MapearTipoEntrada(DataRow fila)
        {
            var tipoE = new TipoEntrada()
            {
                id_tipo_entrada = Convert.ToInt32(fila["id_tipo_entrada"]),
                Nombre = fila["nombre"].ToString()
            };
            return tipoE;
        }
    }
}
