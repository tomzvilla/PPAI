using PPAI.ClasesDiseño;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class Sede
    {
        public int id_sede { get; set; }
        public int cantMaxVisitantes { get; set; }
        public int cantMaxPorGuia { get; set; }
        public string nombre { get; set; }
        public List<Tarifa> tarifas { get; set; }
        //public List<Coleccion> coleccion { get; set; }
        //public Deposito deposito { get; set; }
        //public List<Planta> planta { get; set; }
        public List<Empleado> empleadoCreo { get; set; }
        //public List<Horario> horario { get; set; }
        public List<Exposicion> exposiciones { get; set; }

        private IEstrategiaCalcularDuracionExposicion estrategia;


        public List<Tarifa> conocerTarifas()
        {
            return this.tarifas;
        }

        public List<Empleado> conocerEmpleado()
        {
            return this.empleadoCreo;
        }

        public string mostrarNombre()
        {
            return this.nombre;
        }

        public List<Tarifa> obtenerTarifasVigentes(DateTime? fecha)
        {
            // Recorre todas las tarifas de la sede con un loop, y a cada tarifa le envia un mensaje
            // pasando como parámetro la fecha actual. Retorna un array de objetos tarifa vigentes.
            var _tarifas = this.tarifas;
            var tarifasVigentes = new List<Tarifa>();
            int i = 0;
            while (i < _tarifas.Count())
            {
                var tv = _tarifas[i].buscarTarifasVigentes(fecha);
                i += 1;
                if (tv != null)
                {
                    tarifasVigentes.Add(tv);
                }
            }
            return tarifasVigentes;
        }

        public int calcularDuracionAExposicionesVigentes(DateTime fechaActual, TipoVisita tipoVisita)
        {
            // A cada exposicion almacenada en la sede, le envia un mensaje, para saber si es vigente
            // Si la exposicion es vigente, le envia un mensaje para calcular su duracion
            // Retorna la duracion de la visita completa

            this.crearEstrategia(tipoVisita);

            int duracionVisita = this.calcularDuracion(fechaActual, this.exposiciones);

            return duracionVisita;

        }

        private int calcularDuracion(DateTime fechaActual, List<Exposicion> expos)
        {
            return this.estrategia.calcularDuracionAExposicionesVigentes(fechaActual, expos);
        }

        public int getCantidadMaximaVisitantes()
        {
            // Devuelve el atributo con la cantidad maxima de visitantes diarios de la sede
            return this.cantMaxVisitantes;
        }

        private void crearEstrategia(TipoVisita tipoVisita)
        {
            if(tipoVisita.mostrarNombre() == "Completa")
            {
                var estrat = new EstrategiaDuracionCompleta();
                this.agregarEstrategia(estrat);

            } else if(tipoVisita.mostrarNombre() == "Por Exposicion")
            {
                //estrat = new EstrategiaDuracionPorExposicion();
            }

        }

        private void agregarEstrategia(IEstrategiaCalcularDuracionExposicion estrat)
        {
            this.estrategia = estrat;
        }
    }
}
