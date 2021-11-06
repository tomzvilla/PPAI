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
    public class TarifaRepositorio
    {
        public List<Tarifa> obtenerTarifas(int id)
        {
            var tarifas = new List<Tarifa>();
            var sentenciaSQL = $"SELECT T.*,TE.nombre as nombreE, TV.nombre as nombreV  FROM tarifaXsede TXS JOIN tarifa T ON TXS.id_tarifa = T.id_tarifa" +
                $" JOIN tipo_entrada TE ON T.id_tipo_entrada = TE.id_tipo_entrada" +
                $" JOIN tipo_visita TV ON T.id_tipo_visita = TV.id_tipo_visita" +
                $" WHERE TXS.id_sede = {id}";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSQL);
            foreach(DataRow fila in tabla.Rows)
            {
                var tarifa = MapearTarifa(fila);
                tarifas.Add(tarifa);
            }
            return tarifas;
        }

        public Tarifa obtenerTarifa(int entrada, int visita)
        {
            var tarifa = new Tarifa();
            var sentenciaSQL = $"SELECT T.*,TE.nombre as nombreE, TV.nombre as nombreV FROM Tarifa T JOIN tipo_entrada TE ON T.id_tipo_entrada = TE.id_tipo_entrada" +
                $" JOIN tipo_visita TV ON T.id_tipo_visita = TV.id_tipo_visita" +
                $" WHERE TE.id_tipo_entrada = {entrada} AND TV.id_tipo_visita ={visita}";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSQL);
            foreach (DataRow fila in tabla.Rows)
            {
                tarifa = MapearTarifa(fila);
            }
            return tarifa;
        }

        private Tarifa MapearTarifa(DataRow fila)
        {
            var tarifa = new Tarifa();
            tarifa.id_tarifa = Convert.ToInt32(fila["id_tarifa"]);
            tarifa.fechaFinVigencia = Convert.ToDateTime(fila["fec_fin_vigencia"]);
            tarifa.fechaInicioVigencia = Convert.ToDateTime(fila["fec_inicio_vigencia"]);
            tarifa.Monto = Convert.ToInt32(fila["monto"]);
            tarifa.MontoAdicionalGuia = Convert.ToInt32(fila["monto_adicional_guia"]);
            var tipoE = new TipoEntrada()
            {
                id_tipo_entrada = Convert.ToInt32(fila["id_tipo_entrada"]),
                Nombre = fila["nombreE"].ToString()
            };
            var tipoV = new TipoVisita()
            {
                id_tipo_visita = Convert.ToInt32(fila["id_tipo_visita"]),
                Nombre = fila["nombreV"].ToString()
            };
            tarifa.tipoEntrada = tipoE;
            tarifa.tipoVisita = tipoV;
            return tarifa;
        }
    }
}
