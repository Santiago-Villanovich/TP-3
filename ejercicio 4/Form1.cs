using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double valor1 = 0, valor2 = 0, resultado = 0;

        private void multiplicacion_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(textBox.Text);
            valor2 = double.Parse(textBox1.Text);
            resultado = valor1 * valor2;
            textResultado.Text = string.Format("{0}", resultado);
        }

        private void division_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(textBox.Text);
            valor2 = double.Parse(textBox1.Text);
            resultado = valor1 / valor2;
            textResultado.Text = string.Format("{0}", resultado);
        }

        private void potencia_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(textBox.Text);
            valor2 = double.Parse(textBox1.Text);
            resultado = Math.Pow(valor1,valor2);
            textResultado.Text = string.Format("{0}", resultado);
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            textBox1.Text = "";
            valor1 = 0;
            valor2 = 0;
            resultado = 0;
            textResultado.Text = "0";
        }

        private void raiz_Click(object sender, EventArgs e)
        {
            valor1 = Math.Sqrt(double.Parse(textBox.Text));
            valor2 = Math.Sqrt(double.Parse(textBox1.Text));
            textResultado.Text = string.Format("a= {0}     b= {1}", valor1, valor2);
        }

        private void resta_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(textBox.Text);
            valor2 = double.Parse(textBox1.Text);
            resultado = valor1 - valor2;
            textResultado.Text = string.Format("{0}", resultado);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(textBox.Text);
            valor2 = double.Parse(textBox1.Text);
            resultado = valor1 + valor2;
            textResultado.Text = string.Format("{0}",resultado);
        }
    }
}
