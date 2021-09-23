using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int indice = 0;
        float temperaturaInicio = 0, temperaturaFin = 0;


        private void selector_SelectedIndexChanged(object sender, EventArgs e)
        {
            indice = selector.SelectedIndex; // 0=C  1=F  2=K  3=R

            temperaturaInicio = float.Parse(input.Text);

            if (indice == 1)
            {
                temperaturaInicio = (temperaturaInicio * 9 / 5) + 32;
            }

            if (indice == 2)
            {
                string aux = Convert.ToString(273.15M);
                temperaturaInicio += float.Parse(aux);
            }

            if (indice == 3)
            {
                string aux = Convert.ToString(491.67M);
                temperaturaInicio = (temperaturaInicio * 9 / 5) + float.Parse(aux);
            }
        }

        private void celsius_Click(object sender, EventArgs e)
        {
            temperaturaFin = temperaturaInicio;

            if (indice == 1)
            {
                temperaturaFin = (temperaturaInicio - 32) * 5 / 9;
            }

            if (indice == 2)
            {
                
            }

            if (indice == 3)
            {
                
            }
            
            

            output.Text = temperaturaFin.ToString();
            nuevaTemp.Text = "°C";
        }

        private void fahrenheit_Click(object sender, EventArgs e)
        {
            nuevaTemp.Text = "°F";
        }

        private void kelvin_Click(object sender, EventArgs e)
        {
            nuevaTemp.Text = "°K";
        }

        private void rankine_Click(object sender, EventArgs e)
        {
            nuevaTemp.Text = "°R";
        }
    }
}
