using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProyectoTallerII
{
    public partial class form_inicio : Form
    {
        public form_inicio()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pnl_sidevar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_username_Click(object sender, EventArgs e)
        {

        }

        private void pb_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pb_full_screen_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            pb_maximizar.Visible = false;
            pb_restaurado.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            pb_restaurado.Visible = false;
            pb_maximizar.Visible = true;
        }

        private void pnl_cabecera_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl_contenido_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_reloj.Text = DateTime.Now.ToLongTimeString();
        }

        private void form_inicio_Load(object sender, EventArgs e)
        {
            string[] series = {"Alianzas","Collares","Pulseras","Pendientes"};
            int[] cantidad = { 20, 55, 30, 20 };

            for(int i = 0; i < series.Length; i++)
            {
                //titulos
                Series serie = chart1.Series.Add(series[i]);
                serie.Label = cantidad[i].ToString();
                serie.Points.Add(cantidad[i]);
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
