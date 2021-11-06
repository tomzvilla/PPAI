using PPAI.Gestor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI.Interfaces
{
    public partial class pantallaRegistrarVentaEntradas2 : Form
    {
        private GestorVentaEntradas gestor;
        public pantallaRegistrarVentaEntradas2(GestorVentaEntradas _gestor)
        {
            gestor = _gestor;
            InitializeComponent();
        }

        public void setDuracion(int duracionEstimada)
        {
            txt_duracion.Text = duracionEstimada.ToString();
        }

        public void solicitarSeleccionCantEntradas()
        {
            // Habilita el selector de entradas
            num_cant_entradas.ReadOnly = false;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_continuar_Click(object sender, EventArgs e)
        {
            if (num_cant_entradas.Value <= 0)
            {
                MessageBox.Show("No puede seleccionar cantidades negativas o cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.gestor.tomarSeleccionCantEntradas();

        }

        public int tomarSeleccionCantEntradas()
        {
            // Devuelve la cantidad de entradas ingresadas en el selector
            var cantEntradas = Convert.ToInt32(num_cant_entradas.Value);
            return cantEntradas;
        }

        public void noHayEspacio(int cant, int cantMax)
        {
            MessageBox.Show($"No hay espacio disponible, ocupacion actual: {cant} de {cantMax}", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
