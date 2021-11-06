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
    public partial class pantallaRegistrarVentaEntradas : Form
    {
        private GestorVentaEntradas gestor;
        public pantallaRegistrarVentaEntradas(GestorVentaEntradas _gestor)
        {
            this.gestor = _gestor;
            InitializeComponent();
            //habilitarPantalla();
            //gestor.opcionRegistrarVentaEntradas();
        }

        private void pantallaRegistrarVentaEntradas_Load(object sender, EventArgs e)
        {
            
        }

        private void habilitarPantalla()
        {
            this.ShowDialog();
            return;
        }

        public void setearUsuario(string nombre)
        {
            txt_usuario.Text = nombre;
        }

        public void setearSede(string nombre)
        {
            txt_sede.Text = nombre;
        }

        public void setearMontoGuia(int montoAdicionalGuia)
        {
            txt_monto_guia.Text = Convert.ToString(montoAdicionalGuia);
        }

        public void mostrarTarifasVigentes(string[,] tv)
        {
            for(int i = 0; i < tv.GetLength(0);i++)
            {
                var fila = new string[]
                {
                    tv[i,1].ToString(),
                    tv[i,2].ToString(),
                    tv[i,0].ToString()
                };
                dgv_tarifas.Rows.Add(fila);
            }
        }

        public Tarifa tomarSeleccionTarifa()
        {
            throw new NotImplementedException();
        }

        public void solicitarSeleccionTarifa(List<TipoEntrada> tipoEntradas, List<TipoVisita> tipoVisitas)
        {
            // Este mensaje carga en los combobox los valores de tipoEntrada y tipoVisita
            // Combobox tipo Entrada

            var tipoEntradaDefault = new TipoEntrada();
            tipoEntradaDefault.Nombre = "Seleccionar";
            tipoEntradaDefault.id_tipo_entrada = -1;
            tipoEntradas.Add(tipoEntradaDefault);

            var conector = new BindingSource();
            conector.DataSource = tipoEntradas;

            cmb_tipo_entrada.DataSource = conector;
            cmb_tipo_entrada.DisplayMember = "Nombre";
            cmb_tipo_entrada.ValueMember = "id_tipo_entrada";
            cmb_tipo_entrada.SelectedItem = tipoEntradaDefault;

            // Combobox tipo visita

            var tipoVisitaDefault = new TipoVisita();
            tipoVisitaDefault.Nombre = "Seleccionar";
            tipoVisitaDefault.id_tipo_visita = -1;
            tipoVisitas.Add(tipoVisitaDefault);

            var conector2 = new BindingSource();
            conector2.DataSource = tipoVisitas;

            cmb_tipo_visita.DataSource = conector2;
            cmb_tipo_visita.DisplayMember = "Nombre";
            cmb_tipo_visita.ValueMember = "id_tipo_visita";
            cmb_tipo_visita.SelectedItem = tipoVisitaDefault;
        }

        private void btn_continuar_Click(object sender, EventArgs e)
        {
            if (((TipoEntrada)cmb_tipo_entrada.SelectedItem).id_tipo_entrada == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de entrada", "Error", MessageBoxButtons.OKCancel);
                return;
            }
            if (((TipoVisita)cmb_tipo_visita.SelectedItem).id_tipo_visita == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de visita", "Error", MessageBoxButtons.OKCancel);
                return;
            }
            gestor.tomarSeleccionTarifa();

            
        }

        public List<string> tomarSeleccionTarifa(GestorVentaEntradas _gestor)
        {
            var tarifaSeleccionada = new List<string>();

            var entrada = ((TipoEntrada)cmb_tipo_entrada.SelectedItem).id_tipo_entrada.ToString();
            var visita = ((TipoVisita)cmb_tipo_visita.SelectedItem).id_tipo_visita.ToString();
            var guia = ck_guiado.Checked.ToString();

            tarifaSeleccionada.Add(entrada);
            tarifaSeleccionada.Add(visita);
            tarifaSeleccionada.Add(guia);

            return tarifaSeleccionada;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
