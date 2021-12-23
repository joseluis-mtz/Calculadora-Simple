using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora_simple
{
    class Operaciones
    {
        public double Sumar(double num1, double num2)
        {
            double resultado = num1 + num2;
            return resultado;
        }

        public double Restar(double num1, double num2)
        {
            double resultado = 0;
            if (num1 >= num2)
            {
                resultado = num1 - num2;
            }
            else
            {
                MessageBox.Show("Error al restar, el resultado es negativo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return resultado;
        }

        public double Multiplicar(double num1, double num2)
        {
            double resultado = num1 * num2;
            return resultado;
        }

        public double Dividir(double num1, double num2)
        {
            double resultado = 0;
            if (num2 > 0)
            {
                resultado = num1 / num2;
            }
            else
            {
                MessageBox.Show("Error, intento de división por CERO (0)", "ERROR: OPERACIÓN IMPOSIBLE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Math.Round(resultado, 4);

        }
    }
}
