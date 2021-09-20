using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_7
{
    public partial class Form1 : Form
    {
        int n = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void ingresar_Click(object sender, EventArgs e)
        {
            int n = grid.Rows.Add();
            int m = int.Parse(monto.Text);
            int t = int.Parse(tasa.Text);
            int d = int.Parse(dias.Text);


            int resultado = (m * t * d / 36500);

            grid.Rows[n].Cells[0].Value = usuario.Text;
            grid.Rows[n].Cells[1].Value = monto.Text;
            grid.Rows[n].Cells[2].Value = tasa.Text;
            grid.Rows[n].Cells[3].Value = dias.Text;
            grid.Rows[n].Cells[4].Value = resultado;

            usuario.Text = "";
            monto.Text = "";
            tasa.Text = "";
            dias.Text = "";
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            if (n != -1)
            {
                grid.Rows.RemoveAt(n);
            }
            
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;
        }
    }
}
