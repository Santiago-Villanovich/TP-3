using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            numero1.Text = "";
            numero2.Text = "";
            resultado2.Text = "";
        }

        private void igual_Click(object sender, EventArgs e)
        {
            double n1, n2, r;

            n1 = double.Parse(numero1.Text);
            n2 = double.Parse(numero2.Text);
            r = n1 + n2;

            resultado2.Text = r.ToString();
        }
    }
}
