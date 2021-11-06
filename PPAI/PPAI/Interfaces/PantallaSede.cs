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
    public partial class PantallaSede : Form
    {
        private GestorVentaEntradas gestor;
        public int cantidadVisitantesHoy;
        public PantallaSede(GestorVentaEntradas _gestor)
        {
            gestor = _gestor;
            cantidadVisitantesHoy = gestor.cantidadAntes;
            InitializeComponent();
        }

        public void actualizarCantidadVisitantes(int cantEntradas)
        {
            var cantidadVisitantesHoy = gestor.cantidadAntes + cantEntradas;
            lbl_cant_visitantes.Text = cantidadVisitantesHoy.ToString();
        }
    }
}
