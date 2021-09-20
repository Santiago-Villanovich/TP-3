using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_6
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

            int stop = Convert.ToInt32(textBox.Text);
            int i, f1 = 1, f2 = 1, f3 = 0;

            listBox1.Items.Add(f1);
            listBox1.Items.Add(f2);

            for ( i = 3; i <= stop; i++)
            {
                f3 = f1 + f2;
                listBox1.Items.Add(f3);
                f1 = f2;
                f2 = f3;
            }
        }
    }
}
