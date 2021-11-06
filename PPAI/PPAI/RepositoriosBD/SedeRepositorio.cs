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
    public class SedeRepositorio
    {
        public Sede obtenerSede(int id)
        {
            var sede = new Sede();
            var sentenciaSQL = $"SELECT * FROM sede WHERE id_sede = {id}  ";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSQL);
            foreach(DataRow fila in tabla.Rows)
            {
                sede = MapearSede(fila);
            }
            return sede;
        }

        private Sede MapearSede(DataRow fila)
        {
            var sede = new Sede();
            sede.id_sede = Convert.ToInt32(fila["id_sede"]);
            sede.cantMaxPorGuia = Convert.ToInt32(fila["cant_ma_por_guia"]);
            sede.cantMaxVisitantes = Convert.ToInt32(fila["cant_max_visitantes"]);
            sede.nombre = fila["nombre"].ToString();
            return sede;
        }
    }
}
