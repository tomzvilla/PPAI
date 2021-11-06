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
    public class TipoVisitaRepositorio
    {
        public List<TipoVisita> getTipoVisitas()
        {
            var tipoVisitas = new List<TipoVisita>();
            var sentenciaSQL = $"SELECT * FROM tipo_visita";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSQL);
            foreach(DataRow fila in tabla.Rows)
            {
                var tipoVisita = MapearTipoVisita(fila);
                tipoVisitas.Add(tipoVisita);
            }
            return tipoVisitas;
        }

        private TipoVisita MapearTipoVisita(DataRow fila)
        {
            var tipoV = new TipoVisita()
            {
                id_tipo_visita = Convert.ToInt32(fila["id_tipo_visita"]),
                Nombre = fila["nombre"].ToString()
            };
            return tipoV;
        }
    }
}
