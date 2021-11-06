using PPAI.Entidades;
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
    public partial class detalleEntrada : Form
    {
        private GestorVentaEntradas gestor;
        public detalleEntrada(GestorVentaEntradas _gestor)
        {
            gestor = _gestor;
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void mostrarDetalleEntradas(int cantidadEntradas, Tarifa tarifaSeleccionada, bool esGuiada)
        {
            int montoUnitario = tarifaSeleccionada.Monto;
            lbl_cantidad.Text = cantidadEntradas.ToString();
            lbl_tipo_entrada.Text = tarifaSeleccionada.tipoEntrada.mostrarNombre();
            lbl_tipo_visita.Text = tarifaSeleccionada.tipoVisita.mostrarNombre();
            string guiada;
            if (esGuiada)
            {
                guiada = "Si";
                montoUnitario += tarifaSeleccionada.MontoAdicionalGuia;
            }
            else
                guiada = "No";
            lbl_es_guiada.Text = guiada;
            lbl_precio_unitario.Text = montoUnitario.ToString();
            lbl_total_pagar.Text = (montoUnitario * cantidadEntradas).ToString();
        }

        public void solicitarConfirmacionVenta()
        {
            // Me habilita la opcion de confirmar la venta
            btn_continuar.Enabled = true;
        }

        public bool tomarConfirmacionVenta()
        {
            // Me abre un pop-up que pregunta si se desea confirmar la venta
            DialogResult resultado = MessageBox.Show("¿Seguro que desea confirmar la compra?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(resultado == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }

        private void btn_continuar_Click(object sender, EventArgs e)
        {
            this.gestor.tomarConfirmacionVenta();
        }
    }
}
