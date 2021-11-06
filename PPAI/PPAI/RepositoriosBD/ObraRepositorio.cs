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
    public class ObraRepositorio
    {
        public Obra obtenerObra(int id)
        {
            var obra = new Obra();
            var tipoEntradas = new List<Obra>();
            var sentenciaSQL = $"SELECT DE.id_obra, O.nombre, O.duracion_extendida,O.duracion_resumida FROM detalle_exposicion DE" +
                $" JOIN obra O ON O.id_obra = DE.id_obra" +
                $" WHERE DE.id_obra = {id}";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSQL);
            foreach(DataRow fila in tabla.Rows)
            {
                obra = MapearObra(fila);
            }
            return obra;
        }

        private Obra MapearObra(DataRow fila)
        {
            var obra = new Obra()
            {
                nombreObra = fila["nombre"].ToString(),
                id_obra = Convert.ToInt32(fila["id_obra"]),
                duracionExtendida = Convert.ToInt32(fila["duracion_extendida"]),
                duracionResumida = Convert.ToInt32(fila["duracion_resumida"])
            };
            return obra;
        }
    }
}
