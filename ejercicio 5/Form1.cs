using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (uint.Parse(minimo.Text) < uint.Parse(maximo.Text))
            {
                /* uint n = uint.Parse(minimo.Text);
                 uint m = uint.Parse(maximo.Text);


                do
                 {

                     if (n % 2 != 0)
                     {
                         listBox1.Items.Add(n.ToString());
                     }
                     n++;

                 } while (n<m);*/

                
                    int i, j;
                    int contador = 0;

                    int numeroMin = Convert.ToInt32(minimo.Text);
                    int numeroMax = Convert.ToInt32(maximo.Text);

                    for (i = numeroMin; i <= numeroMax; i++)
                    {
                        contador = 0;

                        for (j = numeroMin; j <= i; j++)
                        {
                            if (i % 1 == 0 && i % j == 0)
                            {
                                contador++;
                            }
                        }

                        if (contador == 2)
                        {
                            listBox1.Items.Add(i.ToString());
                        }
                    }
            }
            else
            {
                MessageBox.Show("Los datos ingresados son incorrectos");
            }

            
        }

        private void maximo_Click(object sender, EventArgs e)
        {
            if(maximo.Text == "(Ingrese un valor maximo)")
            {
                maximo.Text = "";
            }
        }

        private void maximo_TextChanged(object sender, EventArgs e)
        {

        }

        private void minimo_Click(object sender, EventArgs e)
        {
            if (minimo.Text == "(Ingrese un valor minimo)")
            {
                minimo.Text = "";
            }
        }
    }
}
