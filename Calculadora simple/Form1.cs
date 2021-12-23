using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora_simple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea cerrar el sistema?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (resultado == DialogResult.No)
            {

            }
        }

        private void txtNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Libreria_validacion.Validar.SoloNumeros(e);
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                SendKeys.Send(("{TAB}"));
            }
        }

        private void txtNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Libreria_validacion.Validar.SoloNumeros(e);
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                SendKeys.Send(("{TAB}"));
            }
        }

        private void txtLet_KeyPress(object sender, KeyPressEventArgs e)
        {
            Libreria_validacion.Validar.SoloLetras(e);
        }
    }
}
