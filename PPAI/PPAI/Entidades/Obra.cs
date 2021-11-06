using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class Obra
    {
        public int id_obra { get; set; }
        public int alto { get; set; }
        public int ancho { get; set; }
        public int codigoSensor { get; set; }
        public String descripcion { get; set; }
        public int duracionExtendida { get; set; }
        public int duracionResumida { get; set; }
        public DateTime? fechaCreacion { get; set; }

        public DateTime? fechaPrimerIngreso { get; set; }
        public String nombreObra { get; set; }
        public int peso { get; set; }
        public int valuacion { get; set; }
        public Empleado empleadoCreo { get; set; }
        //public Artista artistaQuePinto { get; set; }
        //public List<CambioEstado> cambioEstado { get; set; }
        //public Compra compra { get; set; }
        //public Donacion donacion { get; set; }
        //public Estilo estilo { get; set; }
        //public Prestamo prestamo { get; set; }
        //public List<Prestamo> prestamoMuseo { get; set; }
        //public List<Restauracion> restauracionRealizada { get; set; }
        //public Deposito sectorDeposito { get; set; }
        //public Tecnica tecnica { get; set; }
        //public Tematica tematica { get; set; }
        //public TipoIngreso tipoIngreso { get; set; }
        //public List<Archivo> archivo { get; set; }


        public int getDuracionResumida()
        {
            // Devuelve la cantidad de minutos que demora el guia en explicar la obra en forma resumida
            return this.duracionResumida;
        }

        //def conocerArtista(self) :
        //    pass

        //def conocerCambioEstado(self) :
        //    pass

        //def conocerCompra(self) :
        //    pass

        //def conocerDonacion(self) :
        //    pass

        //def conocerEmpleado(self) :
        //    pass

        //def conocerEstilo(self) :
        //    pass

        //def conocerPrestamo(self) :
        //    pass

        //def conocerPrestamoAMuseo(self) :
        //    pass

        //def conocerRestauracion(self) :
        //    pass

        //def conocerSectorAsignado(self) :
        //    pass

        //def conocerTecnica(self) :
        //    pass

        //def conocerTematica(self) :
        //    pass

        //def conocerTipoIngreso(self) :
        //    pass
    }
}
