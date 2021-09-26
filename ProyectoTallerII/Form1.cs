using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTallerII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt_pass.Focus();
            }
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            if (txt_user.Text == "" && txt_pass.Text == "")
            {
                MessageBox.Show("Campos vacíos, por favor ingrese su cuenta", "ERROR!",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information
               );
                txt_pass.Clear();
                txt_user.Clear();
                txt_user.Focus();
            }
            else if(txt_user.Text == "Admin1" && txt_pass.Text == "Adm1n123!")
            {
                Form form_inicio = new form_inicio();
                this.Hide();
                form_inicio.Show();

            }
            else
            {
                MessageBox.Show("Usuario y(o Contraseña incorrectas", "ERROR!",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information
               );
                txt_pass.Clear();
                txt_user.Clear();
                txt_user.Focus();
            }

        }
    }
}