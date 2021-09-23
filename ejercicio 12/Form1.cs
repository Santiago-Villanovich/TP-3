using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }

            if (colorDialog1.Color == Color.Black)
            {
                label1.ForeColor = Color.White;
                button1.ForeColor = Color.White;
            
            }
            else
            {
                label1.ForeColor = Color.Black;
                button1.ForeColor = Color.Black;
            }
        }
    }
}
