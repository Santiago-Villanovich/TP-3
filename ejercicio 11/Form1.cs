using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_11
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            indicador.Text = "Rojo";
            indicador.ForeColor = Color.Red;
        }

        Boolean estado = true;

        private void picture1_Click(object sender, EventArgs e)
        {

            if (estado)
            {
                picture1.BackColor = Color.Red;
            }
            else
            {
                picture1.BackColor = Color.Blue;
            }

            if (estado)
            {
                estado = false;
                indicador.Text = "Azul";
                indicador.ForeColor = Color.Blue;
            }
            else
            {
                estado = true;
                indicador.Text = "Rojo";
                indicador.ForeColor = Color.Red;
            }
            
        }

        private void picture2_Click(object sender, EventArgs e)
        {
            if (estado)
            {
                picture2.BackColor = Color.Red;
            }
            else
            {
                picture2.BackColor = Color.Blue;
            }

            if (estado)
            {
                estado = false;
                indicador.Text = "Azul";
                indicador.ForeColor = Color.Blue;
            }
            else
            {
                estado = true;
                indicador.Text = "Rojo";
                indicador.ForeColor = Color.Red;
            }
        }

        private void picture3_Click(object sender, EventArgs e)
        {
            if (estado)
            {
                picture3.BackColor = Color.Red;
            }
            else
            {
                picture3.BackColor = Color.Blue;
            }

            if (estado)
            {
                estado = false;
                indicador.Text = "Azul";
                indicador.ForeColor = Color.Blue;
            }
            else
            {
                estado = true;
                indicador.Text = "Rojo";
                indicador.ForeColor = Color.Red;
            }
        }

        private void picture4_Click(object sender, EventArgs e)
        {
            if (estado)
            {
                picture4.BackColor = Color.Red;
            }
            else
            {
                picture4.BackColor = Color.Blue;
            }

            if (estado)
            {
                estado = false;
                indicador.Text = "Azul";
                indicador.ForeColor = Color.Blue;
            }
            else
            {
                estado = true;
                indicador.Text = "Rojo";
                indicador.ForeColor = Color.Red;
            }
        }

        private void picture5_Click(object sender, EventArgs e)
        {
            if (estado)
            {
                picture5.BackColor = Color.Red;
            }
            else
            {
                picture5.BackColor = Color.Blue;
            }

            if (estado)
            {
                estado = false;
                indicador.Text = "Azul";
                indicador.ForeColor = Color.Blue;
            }
            else
            {
                estado = true;
                indicador.Text = "Rojo";
                indicador.ForeColor = Color.Red;
            }
        }

        private void picture6_Click(object sender, EventArgs e)
        {
            if (estado)
            {
                picture6.BackColor = Color.Red;
            }
            else
            {
                picture6.BackColor = Color.Blue;
            }

            if (estado)
            {
                estado = false;
                indicador.Text = "Azul";
                indicador.ForeColor = Color.Blue;
            }
            else
            {
                estado = true;
                indicador.Text = "Rojo";
                indicador.ForeColor = Color.Red;
            }
        }

        private void picture7_Click(object sender, EventArgs e)
        {
            if (estado)
            {
                picture7.BackColor = Color.Red;
            }
            else
            {
                picture7.BackColor = Color.Blue;
            }

            if (estado)
            {
                estado = false;
                indicador.Text = "Azul";
                indicador.ForeColor = Color.Blue;
            }
            else
            {
                estado = true;
                indicador.Text = "Rojo";
                indicador.ForeColor = Color.Red;
            }
        }

        private void picture8_Click(object sender, EventArgs e)
        {
            if (estado)
            {
                picture8.BackColor = Color.Red;
            }
            else
            {
                picture8.BackColor = Color.Blue;
            }

            if (estado)
            {
                estado = false;
                indicador.Text = "Azul";
                indicador.ForeColor = Color.Blue;
            }
            else
            {
                estado = true;
                indicador.Text = "Rojo";
                indicador.ForeColor = Color.Red;
            }
        }

        private void picture9_Click(object sender, EventArgs e)
        {
            if (estado)
            {
                picture9.BackColor = Color.Red;
            }
            else
            {
                picture9.BackColor = Color.Blue;
            }

            if (estado)
            {
                estado = false;
                indicador.Text = "Azul";
                indicador.ForeColor = Color.Blue;
            }
            else
            {
                estado = true;
                indicador.Text = "Rojo";
                indicador.ForeColor = Color.Red;
            }
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
