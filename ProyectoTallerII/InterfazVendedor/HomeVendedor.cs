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
using System.Runtime.InteropServices;
using Common.Cache;

namespace ProyectoTallerII
{
    public partial class Form_vendedor_init : Form
    {
        
        public Form_vendedor_init()
        {
            InitializeComponent();
        }

        

        private void pnl_sidevar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_username_Click(object sender, EventArgs e)
        {

        }

        private void pb_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
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
        /*
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_reloj.Text = DateTime.Now.ToLongTimeString();
        }*/
        /*
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
        }*/

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void open_child_form(object child_form)
        {
            if (this.pnl_contenido.Controls.Count > 0)
                this.pnl_contenido.Controls.RemoveAt(0);
            Form frm = child_form as Form;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.pnl_contenido.Controls.Add(frm);
            this.pnl_contenido.Tag = frm;
            frm.Show();
            
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            open_child_form(new VendedorInicio());
        }

        private void btn_usuarios_Click(object sender, EventArgs e)
        {
            open_child_form(new GerenteAuditoria());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            open_child_form(new Form_facturacion_vendedor());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            open_child_form(new GerenteReportes());
        }

        private void timer_hora_Tick(object sender, EventArgs e)
        {
            //lbl_hora.Text = DateTime.Now.ToLongTimeString();
           // lbl_fecha.Text = DateTime.Now.ToLongDateString();
        }

        private void btn_clientes_gerente_Click(object sender, EventArgs e)
        {
            open_child_form(new IVendedorCliente());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            open_child_form(new Form_listar_productos()); 
        }

        //EVENTO PARA QUE SE PUEDA MOVER EL FORMULARIO A PLACER
        int ejeX; // variables para guardar las coordenadas del mouse
        int ejeY;
        private void pnl_cabecera_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void pnl_cabecera_MouseDown(object sender, MouseEventArgs e)
        {
            //para poder arrastrar el formulario sin bordes

            
            w = this.Width;
            h = this.Height;
        }

        private void pnl_cabecera_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

       
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        Rectangle sizeGripRectangle;
        bool inSizeDrag = false;
        const int GRIP_SIZE = 15;

        int w = 0;
        int h = 0;

        private void bunifuSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("seguro que desea salir?", "SALIR?",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void CargarNombre()
        {
            label_nombre.Text = UserLognCache.nombre_usuario + " " + UserLognCache.apellido_usuario;

        }

        private void Form_vendedor_init_Load(object sender, EventArgs e)
        {
            this.CargarNombre();
        }

        private void btn_hventas_Click(object sender, EventArgs e)
        {
            open_child_form(new VendedorHistorial()); 
        }
    }
}
