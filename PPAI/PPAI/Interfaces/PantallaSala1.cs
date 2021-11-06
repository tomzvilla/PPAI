﻿using PPAI.Gestor;
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
    public partial class PantallaSala1 : Form
    {
        private GestorVentaEntradas gestor;
        public PantallaSala1(GestorVentaEntradas _gestor)
        {
            gestor = _gestor;
            InitializeComponent();
        }

        private void PantallaSala1_Load(object sender, EventArgs e)
        {

        }

        internal void actualizarCantidadVisitantes(int cantEntradas)
        {
            var cantidadVisitantesHoy = gestor.cantidadAntes + cantEntradas;
            lbl_cant_visitantes.Text = cantidadVisitantesHoy.ToString();
        }
    }
}
