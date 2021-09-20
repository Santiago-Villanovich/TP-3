using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double total = 0, aux =0;

        private void sumar_Click(object sender, EventArgs e)
        {
            total += double.Parse(numero.Text);
            aux = double.Parse(numero.Text);
            numero.Text = "";

            if (textoNumeros.Text.Length == 0)
            {
                textoNumeros.Text = string.Format("{0}",aux);
            }
            else
            {
                textoNumeros.Text += string.Format(" + {0}",aux );
            }
            
        }

        private void resta_Click(object sender, EventArgs e)
        {
            total -= double.Parse(numero.Text);
            aux = double.Parse(numero.Text);
            numero.Text = "";

            if (textoNumeros.Text.Length == 0)
            {
                textoNumeros.Text = string.Format("- {0}", aux);
            }
            else
            {
                textoNumeros.Text += string.Format(" - {0}", aux);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void igual_Click(object sender, EventArgs e)
        {
            resultado.Text = "Su resultado es: " + total.ToString();
        }
    }
}
