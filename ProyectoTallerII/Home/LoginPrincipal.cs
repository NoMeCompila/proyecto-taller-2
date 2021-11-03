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
    public partial class LoginPrincipal : Form
    {
        public LoginPrincipal()
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
            else if(txt_user.Text == "123" && txt_pass.Text == "123")
            {
                Form form_inicio = new IHomeAdmin();
                this.Hide();
                form_inicio.Show();

            }
            else if (txt_user.Text == "Gerente1" && txt_pass.Text == "Gerente123!")
            {
                Form form_gerente = new Form_Gerente();
                this.Hide();
                form_gerente.Show();
            }
            else if (txt_user.Text == "fer" && txt_pass.Text == "123")
            {
                Form form_vendedor = new Form_vendedor_init();
                //this.Hide();
                this.Visible = false;
                form_vendedor.Show();
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