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

        public void registrarEntradas(List<Entradas> entradasVendidas)
        {
            using (var tx = DBHelper.GetDBHelper().IniciarTransaccion())
            {
                try
                {
                    // Insertar la entrada en la tabla de entradas
                    for (int i = 0; i < entradasVendidas.Count; i++)
                    {
                        var sentenciaSQL = $"INSERT INTO entrada(fec_venta, hora_venta, monto, numero, id_tarifa, id_sede)" +
                            $" VALUES('{entradasVendidas[i].FechaVenta.ToString("MM-dd-yyyy")}','{entradasVendidas[i].FechaVenta.ToString("HH:m")}',{entradasVendidas[i].Monto}," +
                            $" {entradasVendidas[i].Numero}, {entradasVendidas[i].tarifa.id_tarifa}, {entradasVendidas[i].sede.id_sede})";
                        var ejecutar = DBHelper.GetDBHelper().EjecutarTransaccionSQL(sentenciaSQL);
                    }
                    tx.Commit();
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    throw new ApplicationException("No se pudo registrar la venta.");
                }
                finally
                {
                    DBHelper.GetDBHelper().CloseConnection();
                }
            }

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
