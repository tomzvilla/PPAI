using PPAI.Gestor;
using PPAI.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI
{
    public partial class frmPrincipal : Form
    {
        public GestorVentaEntradas gestor;
        public frmPrincipal()
        {
            gestor = new GestorVentaEntradas();
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            this.gestor.opcionRegistrarVentaEntradas();

        }
    }
}
