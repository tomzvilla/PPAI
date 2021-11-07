using PPAI.Entidades;
using PPAI.Interfaces;
using PPAI.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Gestor
{
    public class GestorVentaEntradas
    {
        public GestorVentaEntradas(frmPrincipal _principal)
        {
            principal = _principal;
        }
        public frmPrincipal principal;
        public Empleado empleadoLogueado { get; set; }
        public Sesion sesionActual = new Sesion() {
            FechaHoraInicio = DateTime.Now,
            usuario = new Usuario() {
                Caducidad = 15,
                Contrasenia = "000",
                Nombre = "Diego",
                empleado = new Empleado() { dni = 14276579 }
            }
        };
        public Sede sedeActual { get; set; }
        public List<Tarifa> tarifasVigentes { get; set; }
        public DateTime fechaActual { get; set; }
        public pantallaRegistrarVentaEntradas pantallaRegistrarVentaEntradas { get; set; }
        public pantallaRegistrarVentaEntradas2 pantallaRegistrarVentaEntradas2 { get; set; }

        public PantallaSede pantallaSede;

        public List<PantallaSala1> pantallasSala;
        public detalleEntrada _detalleEntada { get; set; }
        public Impresora impresora;
        public Tarifa tarifaSeleccionada { get; set; }
        public int duracionEstimada { get; set; }
        public int cantidadEntradas { get; set; }
        public List<Entradas> entradas { get; set; }
        public List<ReservaVisita> reservas { get; set; }
        public bool confirmacion;
        public int ultimoNroEntrada;
        public bool esGuiada;
        //public Impresora impresora;{
        public int cantidadAntes;
        //public List<Pantalla> pantallaSala;
        //public Pantalla pantallaSede;
        public List<Entradas> entradasVendidas;

        public EmpleadoServicio empleadoServicio = new EmpleadoServicio();
        public SedeServicio sedeServicio = new SedeServicio();
        public TarifaServicio tarifaServicio = new TarifaServicio();
        public TipoEntradaServicio tipoEntradaServicio = new TipoEntradaServicio();
        public TipoVisitaServicio tipoVisitaServicio = new TipoVisitaServicio();
        public ExposicionServicio exposicionServicio = new ExposicionServicio();
        public DetalleExposicionServicio detalleExposicionServicio = new DetalleExposicionServicio();
        public ObraServicio obraServicio = new ObraServicio();
        public EntradaServicio entradaServicio = new EntradaServicio();
        public ReservaVisitaServicio reservaVisitaServicio = new ReservaVisitaServicio();

        public void opcionRegistrarVentaEntradas()
        {
            // Pantallas que vienen existiendo de antes

            pantallaSede = new PantallaSede(this);

            this.pantallasSala = new List<PantallaSala1>();
            var p1 = new PantallaSala1(this);
            var p2 = new PantallaSala1(this);
            this.pantallasSala.Add(p1);
            this.pantallasSala.Add(p2);

            // Opcion que se ejecuta en el gestor y que desemboca en una serie de mensajes que coordina el gestor
            // Se instancia un objeto pantalla
            this.pantallaRegistrarVentaEntradas = new pantallaRegistrarVentaEntradas(this);
            
            // Mensajes que el gestor se envia a si mismo
            this.obtenerFechaActual();
            this.buscarEmpleadoLogueado();
            this.buscarSedeActual();
            this.buscarTarifas(this.fechaActual);
            // Mensajes enviados para mostrar informacion en pantalla, para setear valores en los labels

            pantallaRegistrarVentaEntradas.setearUsuario(this.sesionActual.usuario.obtenerNomUsuario());
            pantallaRegistrarVentaEntradas.setearSede(this.sedeActual.mostrarNombre());
           

            // Mensaje que el gestor se envia a si mismo

            this.buscarDatosTarifasVigentes(this.tarifasVigentes);

            // Mensajes enviados para mostrar informacion en pantalla
            // Se obtiene de la BD los tipos de entrada y de visita existentes, para luego cargar el combobox

            var tipoEntradas = tipoEntradaServicio.getTipoEntradas();
            var tipoVisitas = tipoVisitaServicio.getTipoVisitas();
            

            pantallaRegistrarVentaEntradas.solicitarSeleccionTarifa(tipoEntradas, tipoVisitas);
            pantallaRegistrarVentaEntradas.Show();

        }

        private void obtenerFechaActual()
        {
            // Devuelve la fecha en el momento en el que se ejecuta el metodo
            this.fechaActual = DateTime.Now;
        }

        private void buscarEmpleadoLogueado()
        {
            // Envia un mensaje a la sesion actual para obtener el empleado logueado y lo guarda

            empleadoLogueado = sesionActual.obtenerEmpleadoLogueado();
            empleadoLogueado = empleadoServicio.obtenerEmpleado(this.empleadoLogueado.dni);
        }

        private void buscarSedeActual()
        {
            // Envia un mensaje al objeto empleado logueado, para obtener la sede actual y la guarda
            this.sedeActual = this.empleadoLogueado.getSede();
            this.sedeActual = sedeServicio.obtenerSede(this.sedeActual.id_sede);
            this.sedeActual.tarifas = tarifaServicio.obtenerTarifas(this.sedeActual.id_sede);
        }

        private void buscarTarifas(DateTime _fechaActual)
        {
            // Envia un mensaje a la sede actual con el objetivo de obtener las tarifas vigentes,
            // para ello le pasa como parámetro, la fecha actual. Luego almacena las tarifas vigentes
            // y muestra el monto por guia en la pantalla
            this.tarifasVigentes = this.sedeActual.obtenerTarifasVigentes(_fechaActual);
        }

        public void buscarDatosTarifasVigentes(List<Tarifa> tarifasV)
        {
            // Envia un mensaje a cada tarifa vigente para obtener el monto, tipo entrada y tipo visita
            int i = 0;
            string[,] tv = new string[tarifasV.Count, 3];
            
            while (i < tarifasV.Count)
            {

                var monto = tarifasV[i].Monto;
                var tipoEntradayVisita = tarifasV[i].buscarDatosTarifasVigentes();
                tv[i, 0] = monto.ToString();
                tv[i, 1] = tipoEntradayVisita[0];
                tv[i, 2] = tipoEntradayVisita[1];
                i += 1;
            }
            this.pantallaRegistrarVentaEntradas.setearMontoGuia(tarifasVigentes[0].MontoAdicionalGuia);
            this.pantallaRegistrarVentaEntradas.mostrarTarifasVigentes(tv);

        }

        public void tomarSeleccionTarifa(List<string> tarifaS)
        {
            //  Guarda los datos de la tarifa seleccionada, incluyendo si la misma es guiada o no
            // Como la informacion viene en formato texto, obtenemos el objeto tarifa a partir de la informacion recibida
            this.tarifaSeleccionada = tarifaServicio.obtenerTarifa(Convert.ToInt32(tarifaS[0]), Convert.ToInt32(tarifaS[1]));
            this.esGuiada = Convert.ToBoolean(tarifaS[2]);

            //Continua la ejecucion del CU, con mensajes self al gestor
            this.buscarExposicionVigente(this.tarifaSeleccionada.tipoVisita);
        }

        private void buscarExposicionVigente(TipoVisita tipoVisita) 
        {
            // Obtener exposiciones por sede
            this.sedeActual.exposiciones = exposicionServicio.obtenerExposiciones(this.sedeActual.id_sede);
            // Obtener detalles exposicion por cada exposicion
            for(int i = 0; i < this.sedeActual.exposiciones.Count; i++)
            {
                var detalles = detalleExposicionServicio.obtenerDetalleExposiciones(this.sedeActual.exposiciones[i].id_exposicion);
                foreach (DetalleExposicion detalle in detalles)
                    this.sedeActual.exposiciones[i].detalleExposicion.Add(detalle);

                // Obtener obras de cada detalle

                for (int j = 0; j < this.sedeActual.exposiciones[i].detalleExposicion.Count; j++)
                {
                    this.sedeActual.exposiciones[i].detalleExposicion[j].obra = obraServicio.obtenerObra(this.sedeActual.exposiciones[i].detalleExposicion[j].obra.id_obra);
                }
            }

            // Instancia una pantalla

            this.pantallaRegistrarVentaEntradas2 = new pantallaRegistrarVentaEntradas2(this);

            // Calcula y almacena la duracion estimada de la visita completa al museo

            this.duracionEstimada = this.sedeActual.calcularDuracionAExposicionesVigentes(this.fechaActual, tipoVisita);
            this.pantallaRegistrarVentaEntradas2.setDuracion(this.duracionEstimada);

            //  Instancia, con un mensaje a la pantalla, la continuacion del CU

            this.pantallaRegistrarVentaEntradas2.solicitarSeleccionCantEntradas();
            this.pantallaRegistrarVentaEntradas2.ShowDialog();

        }

        public void tomarSeleccionCantEntradas()
        {
            // Recibe de la pantalla la informacion sobre la cantidad de entradas seleccionada
            this.cantidadEntradas = this.pantallaRegistrarVentaEntradas2.tomarSeleccionCantEntradas();

            // El gestor se envia un mensaje a si mismo
            this.buscarCapacidadSede();
        }

        public void buscarCapacidadSede()
        {
            //Calcula la capacidad actual y busca la maxima de la sede
            //y en funcion de la cantidad de entradas a vender, permite o no la venta

            int cantMax = this.sedeActual.getCantidadMaximaVisitantes();
            int cantVisitantes = this.buscarVisitantesEnSede();
            int cantReservas = this.buscarReservasParaAsistir();
            var hayEspacio = this.validarLimiteVisitantes(cantMax, cantVisitantes, cantReservas);
            if (!hayEspacio)
            {
                this.pantallaRegistrarVentaEntradas2.noHayEspacio(this.cantidadAntes, this.sedeActual.getCantidadMaximaVisitantes());
            }
            else
            {
                this.calcularTotalAPagar();
            }
        }

        public int buscarVisitantesEnSede()
        {
            // Obtiene las entradas de la BD
            this.entradas = entradaServicio.obtenerEntradas();
            //Calcula la cantidad de visitantes actual en funcion de las entradas vendidas el dia actual
            //mandando mensajes a todas las entradas
            int i = 0;
            int cantVisitantes = 0;
            while(i < this.entradas.Count)
            {
                var e = this.entradas[i].esDeFechayHoraSede(this.sedeActual.id_sede, this.fechaActual);
                if (e)
                    cantVisitantes += 1;
                i += 1;
            }
            return cantVisitantes;
        }

        private int buscarReservasParaAsistir()
        {
            // Obtiene las reservas de la BD

            this.reservas = reservaVisitaServicio.obtenerReservas();

            //Calcula la cantidad de visitantes del dia, en funcion de las reservas
            //que fueron realizadas para la fecha actual. La cantidad de visitantes es
            //la cantidad de alumnos que confirmaron que asistirán

            int i = 0;
            int cantReservas = 0;
            while(i < this.reservas.Count)
            {
                var r = this.reservas[i].sonParaFechaHoraSede(this.sedeActual.id_sede, this.fechaActual);
                if (r)
                {
                    cantReservas += this.reservas[i].cantidadAlumnosConfirmada;
                }
                i += 1;
            }
            return cantReservas;
        }

        private bool validarLimiteVisitantes(int cantMax, int cantVisitantes, int cantReservas)
        {
            //Si la cantidad actual de visitantes en el museo, es menor que la cantidad maxima permitida
            //devuelve True, caso contrario, devuelve False
            this.cantidadAntes = cantVisitantes + cantReservas;
            //pantallaSede.cantidadVisitantesHoy = this.cantidadAntes;
            int cantActual = this.cantidadAntes + this.cantidadEntradas;
            if(cantActual <= cantMax)
            {
                return true;
            }
            return false;
        }

        private void calcularTotalAPagar()
        {
            //Este metodo me instancia una nueva interfaz, y le manda mensajes, de forma que
            //se muestren los datos del pago

            this._detalleEntada = new detalleEntrada(this);
            this._detalleEntada.mostrarDetalleEntradas(this.cantidadEntradas, this.tarifaSeleccionada, this.esGuiada);
            this._detalleEntada.solicitarConfirmacionVenta();
            this._detalleEntada.ShowDialog();
            
        }

        public void tomarConfirmacionVenta()
        {
            //Almacena en un atributo si se confirma o no la venta, en forma de valor booleano.
            //Si la venta se confirmo, se manda un mensaje self al gestor
            this.confirmacion = this._detalleEntada.tomarConfirmacionVenta();
            if (this.confirmacion)
            {
                this.buscarUltimoNumeroEntrada();
            }
        }

        private void buscarUltimoNumeroEntrada()
        {
            //Recorre el array de entradas, que posee el gestor, y obtiene el ultimo numero de entrada
            //y se guarda este numero, sumandole uno. El gestor se manda un mensaje self.
            int i = 0;
            var nro = new List<int>();
            while(i < this.entradas.Count)
            {
                nro.Add(this.entradas[i].getNumero());
                i += 1;
            }
            var max = nro.Max();
            this.ultimoNroEntrada = max + 1;
            this.generarNuevaEntrada();
        }

        private void generarNuevaEntrada()
        {
            // Busca los datos necesarios para crear un nuevo objeto entrada, e imprime la entrada en formato PDF
            this.entradasVendidas = new List<Entradas>();
            int i = 0;
            DateTime dia = this.obtenerHoraYMinutos();
            var hora = dia.ToString("HH") + "/" + dia.ToString("m");
            while(i < this.cantidadEntradas)
            {
                var entrada = new Entradas
                {
                    FechaVenta = this.fechaActual,
                    HoraVenta = Convert.ToDateTime(hora),
                    Monto = this.tarifaSeleccionada.Monto,
                    Numero = this.ultimoNroEntrada + i,
                    tarifa = this.tarifaSeleccionada,
                    sede = this.sedeActual
                };
                this.entradasVendidas.Add(entrada);
                i += 1;
            }
            this.entradaServicio.registrarEntradas(this.entradasVendidas);
            this.imprimirEntradas();
            this.calcularCantVisitantesActual(this.cantidadEntradas);
        }


        private DateTime obtenerHoraYMinutos()
        {
            // Devuele el dia, la hora y los minutos actuales
            return DateTime.Now;
        }

        private void imprimirEntradas()
        {
            //Manda a imprimir cada una de las entradas vendidas. Para ello manda un mensaje
            //a la interfaz Impresora

            int i = 0;
            this.impresora = new Impresora();
            while(i < this.entradasVendidas.Count)
            {
                this.impresora.PDFimprimirEntradas(this.entradasVendidas[i], this.esGuiada);
                i += 1;
            }
           
        }

        private void calcularCantVisitantesActual(int cantEntradas)
        {
            //Es un metodo que envia un mensaje a la pantalla Sede, para actualizar al cantidad de visitantes,
            //para ello se envia la cantidad de entradas vendidas. Luego muestra la pantalla a fines tecnicos
            //Realiza la misma funcion, recorriendo un array con todas las pantallas de todas las salas de la sede,
            //enviandoles un mensaje indicando que actualicen el valor de la cantidad de visitantes.

            this.pantallaSede.actualizarCantidadVisitantes(cantEntradas);
            this.pantallaSede.ShowDialog();
            int i = 0;
            while(i < this.pantallasSala.Count)
            {
                this.pantallasSala[i].actualizarCantidadVisitantes(cantEntradas);
                this.pantallasSala[i].ShowDialog();
                i += 1;
            }
            this.finCU();
        }

        private void finCU()
        {
            //Metodo que indica el final del CU. No cerramos el programa, para poder visualizar las pantallas
            //del final del CU. Caso contrario, se cerraría el programa con quit()
            this.pantallaRegistrarVentaEntradas2.Dispose();
            this.pantallaRegistrarVentaEntradas.Dispose();
            this._detalleEntada.Dispose();
            principal.Activate();
        
        }
    }
}
