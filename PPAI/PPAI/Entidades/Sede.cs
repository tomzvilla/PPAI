using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class Sede
    {
        public int cantMaxVisitantes { get; set; }
        public int cantMaxPorGuia { get; set; }
        public String nombre { get; set; }
        public List<Tarifa> tarifas { get; set; }
        public List<Coleccion> coleccion { get; set; }
        public Deposito deposito { get; set; }
        public List<Planta> planta { get; set; }
        public List<Empleado> empleadoCreo { get; set; }
        public List<Horario> horario { get; set; }
        public List<Exposicion> exposiciones { get; set; }

        //    def conocerTarifa(self):
        //    return self.tarifas

        //def conocerEmpleado(self) :
        //    return self.empleadoCreo

        //def mostrarNombre(self) :
        //    return self.nombre

    //    def obtenerTarifasVigentes(self, fecha):
    //    # Recorre todas las tarifas de la sede con un loop, y a cada tarifa le envia un mensaje
    //    # pasando como parámetro la fecha actual. Retorna un array de objetos tarifa vigentes.
    //    tarifas = self.tarifas
    //    tarifasVigentes = []
    //    i = 0
    //    while i<len(tarifas):
    //        t = tarifas[i].buscarTarifasVigentes(fecha)
    //        i+=1
    //        if not t == []:
    //            tarifasVigentes.append(t)
    //    return tarifasVigentes

    //def calcularDuracionAExposicionesVigentes(self, fecha) :
    //    # A cada exposicion almacenada en la sede, le envia un mensaje, para saber si es vigente
    //    # Si la exposicion es vigente, le envia un mensaje para calcular su duracion
    //    # Retorna la duracion de la visita completa
    //    i=0
    //    duracionVisita = 0
    //    while i<len(self.exposiciones):
    //        vigencia = self.exposiciones[i].esVigente(fecha)
    //        if vigencia == True:
    //            duracionVisita+= self.exposiciones[i].calcularDuracionObrasExpuestas()
    //        i += 1
    //    return duracionVisita



    //def getCantidadMaximaVisitantes(self) :
    //    # Devuelve el atributo con la cantidad maxima de visitantes diarios de la sede
    //    return self.cantMaxVisitantes
    //}
}
