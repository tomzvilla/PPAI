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
    public class EmpleadoRepositorio
    {
        public Empleado obtenerEmpleado(int dni)
        {
            var empleado = new Empleado();
            var sentenciaSQL = $"SELECT * FROM empleado WHERE dni = {dni} ";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSQL);
            foreach(DataRow fila in tabla.Rows)
            {
                empleado = MapearEmpleado(fila);
            }
            return empleado;
        }

        private Empleado MapearEmpleado(DataRow fila)
        {
            var empleado = new Empleado();
            empleado.apellido = fila["apellido"].ToString();
            empleado.dni = Convert.ToInt32(fila["dni"]);
            empleado.cuit = Convert.ToInt32(fila["cuit"]);
            empleado.codigoValidacion = Convert.ToInt32(fila["cod_validacion"]);
            empleado.sexo = Convert.ToInt32(fila["sexo"]);
            empleado.telefono = Convert.ToInt32(fila["telefono"]);
            empleado.fechaIngreso = Convert.ToDateTime(fila["fec_ingreso"]);
            empleado.fechaNacimiento = Convert.ToDateTime(fila["fec_nacimiento"]);
            empleado.email = fila["email"].ToString();
            empleado.nombre = fila["nombre"].ToString();
            var sede = new Sede();
            sede.id_sede = Convert.ToInt32(fila["id_sede"]);
            empleado.sede = sede;
            empleado.domicilio = fila["domicilio"].ToString();
            return empleado;
        }
    }
}
