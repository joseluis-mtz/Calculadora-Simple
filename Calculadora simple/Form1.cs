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

        Operaciones objOperaciones = new Operaciones();

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

        private void btnSuma_Click(object sender, EventArgs e)
        {
            if (txtNum1.Text.Length > 0 && txtNum2.Text.Length > 0)
            {
                lblRes.Text = "Resultado: " + objOperaciones.Sumar(double.Parse(txtNum1.Text), double.Parse(txtNum2.Text));
            }
            else
            {
                MessageBox.Show("No hay datos para operar.", "Ingrese la información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            if (txtNum1.Text.Length > 0 && txtNum2.Text.Length > 0)
            {
                lblRes.Text = "Resultado: " + objOperaciones.Restar(double.Parse(txtNum1.Text), double.Parse(txtNum2.Text));
            }
            else
            {
                MessageBox.Show("No hay datos para operar.", "Ingrese la información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            if (txtNum1.Text.Length > 0 && txtNum2.Text.Length > 0)
            {
                lblRes.Text = "Resultado: " + objOperaciones.Multiplicar(double.Parse(txtNum1.Text), double.Parse(txtNum2.Text));
            }
            else
            {
                MessageBox.Show("No hay datos para operar.", "Ingrese la información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (txtNum1.Text.Length > 0 && txtNum2.Text.Length > 0)
            {
                lblRes.Text = "Resultado: " + objOperaciones.Dividir(double.Parse(txtNum1.Text), double.Parse(txtNum2.Text));
            }
            else
            {
                MessageBox.Show("No hay datos para operar.", "Ingrese la información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
