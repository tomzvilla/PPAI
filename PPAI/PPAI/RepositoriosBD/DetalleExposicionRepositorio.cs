using PPAI.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.RepositoriosBD
{
    public class DetalleExposicionRepositorio
    {
        public List<DetalleExposicion> obtenerDetalleExposiciones(int id)
        {
            var detalleExpos = new List<DetalleExposicion>();
            string sentenciaSQL = $"SELECT DE.id_exposicion, DE.id_obra FROM detalle_exposicion DE" +
                                  $" WHERE DE.id_exposicion = {id}";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSQL);
            foreach(DataRow fila in tabla.Rows)
            {
                var detalle = MapearDetalleExpo(fila);
                detalleExpos.Add(detalle);
            }
            return detalleExpos;
        }

        private DetalleExposicion MapearDetalleExpo(DataRow fila)
        {
            var detalleExpo = new DetalleExposicion();
            var obra = new Obra()
            {
                id_obra = Convert.ToInt32(fila["id_obra"])
            };
            detalleExpo.obra = obra;

            return detalleExpo;
        }
    }
}
