using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            grid.Rows.Add(5);

            for (int i = 0; i < 6; i++)
            {
                grid.Rows[i].Cells[0].Value = i+1;
                grid.Rows[i].Cells[1].Value = 0;
            }
        }

        int uno = 0, dos = 0, tres = 0, cuatro = 0, cinco = 0, seis = 0, contador=0;
        private void button1_Click(object sender, EventArgs e)
        {
            Random n = new Random();

            int m = n.Next(1, 7);
            label2.Text = m.ToString();

            int k = n.Next(1, 7);
            label3.Text = k.ToString();

            if (m == 1 || k == 1)
            {
                uno++;
                grid.Rows[0].Cells[1].Value = uno ;
            }

            if (m == 2 || k == 2)
            {
                dos++;
                grid.Rows[1].Cells[1].Value = dos;
            }

            if (m == 3 || k == 3)
            {
                tres++;
                grid.Rows[2].Cells[1].Value = tres;
            }

            if (m == 4 || k == 4)
            {
                cuatro++;
                grid.Rows[3].Cells[1].Value = cuatro;
            }

            if (m == 5 || k == 5)
            {
                cinco++;
                grid.Rows[4].Cells[1].Value = cinco;
            }

            if (m == 6 || k == 6)
            {
                seis++;
                grid.Rows[5].Cells[1].Value = seis;
            }

            contador++;

            grid.Rows[0].Cells[2].Value = ((uno*100)/contador);
            grid.Rows[1].Cells[2].Value = ((dos * 100) / contador);
            grid.Rows[2].Cells[2].Value = ((tres * 100) / contador);
            grid.Rows[3].Cells[2].Value = ((cuatro * 100) / contador);
            grid.Rows[4].Cells[2].Value = ((cinco * 100) / contador);
            grid.Rows[5].Cells[2].Value = ((seis * 100) / contador);
        }
    }
}
