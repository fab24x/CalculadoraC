using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double operando1 = 0;
        double operando2 = 0;
        String operacion = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            if (num.Text == "0")
            {
                num.Text = "";
            }
            num.Text += boton.Text;

        }

        private void simbolo_operacion(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            operacion = boton.Text;
            operando1 = Convert.ToDouble(num.Text);
            num.Text = "0";
        }

        private void operacionIgual(object sender, EventArgs e)
        {
            operando2 = Convert.ToDouble(num.Text);
            double resultado = 0;
            if (operacion == "+")
            {
                resultado = operando1 + operando2;
            }
            else if (operacion == "-")
            {
                resultado = operando1 - operando2;
            }
            else if (operacion == "*")
            {
                resultado = operando1 * operando2;
            }
            else if (operacion == "/")
            {
                resultado = operando1 / operando2;
            }
            else if (operacion == "¬2")
            {
                resultado = operando1 * operando1;
            }
            num.Text = Convert.ToString(resultado);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            num.Text = "0";
            operando1 = 0;
            operando2 = 0;
        }


    }
}
