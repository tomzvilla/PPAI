using PPAI.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.RepositoriosBD
{
    public class ExposicionRepositorio
    {
        public List<Exposicion> obtenerExposiciones(int id)
        {
            var exposiciones = new List<Exposicion>();
            string sentenciaSQL = $"SELECT E.id_exposicion, E.nombre as nombreExpo, E.fec_fin, E.fec_inicio FROM exposicion E" +
                $" WHERE E.id_sede = {id}";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSQL);
            foreach(DataRow fila in tabla.Rows)
            {
                var exposicion = MapearExpo(fila);
                exposiciones.Add(exposicion);
            }
            return exposiciones;
        }

        private Exposicion MapearExpo(DataRow fila)
        {
            var expo = new Exposicion();
            expo.id_exposicion = Convert.ToInt32(fila["id_exposicion"]);
            expo.Nombre = fila["nombreExpo"].ToString();
            expo.FechaFin = Convert.ToDateTime(fila["fec_fin"]);
            expo.FechaInicio = Convert.ToDateTime(fila["fec_inicio"]);
            expo.detalleExposicion = new List<DetalleExposicion>();
            return expo;
        }
    }
}
