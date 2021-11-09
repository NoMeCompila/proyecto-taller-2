using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using Common.Cache;

namespace ProyectoTallerII
{
    public partial class LoginUsuarios : Form
    {
        public LoginUsuarios()
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
            else
            {
                //se ionstancia un objeto de tipo UserNegocio
                UserNegocio user = new UserNegocio();
                
                //se les pasa los valores de los textbox a su funcion login
                var validar_login = user.login_user(txt_user.Text, txt_pass.Text);

                //se verifica que valor retornó el método

                if(validar_login == true)
                {
                    if (UserLognCache.id_perfil == Perfiles.Admin) { 
                        IHomeAdmin formu = new IHomeAdmin();
                        formu.Show();
                        formu.FormClosed += LogOut;
                        this.Hide();
                    }

                    if (UserLognCache.id_perfil == Perfiles.Gerente)
                    {
                        IHomeGerente formu = new IHomeGerente();
                        formu.Show();
                        formu.FormClosed += LogOut;
                        this.Hide();
                    }



                    if (UserLognCache.id_perfil == Perfiles.Vendedor)
                    {
                        Form_vendedor_init formu = new Form_vendedor_init();
                        formu.Show();
                        formu.FormClosed += LogOut;
                        this.Hide();
                    }





                }
                else
                {
                    MessageBox.Show("Usuario o contraseña inválidos, por favor intente de nuevo", "ERROR!",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information
               );
                    txt_pass.Clear();
                    txt_user.Clear();
                    txt_user.Focus();
                }
            }
        }

        // funcion que llama a los metodos necesarios para cerrar sesion

        private void LogOut(object sender, FormClosedEventArgs e)
        {
            txt_pass.Clear();
            txt_user.Clear();
            this.Show();
            txt_user.Focus();
        }

        /*
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
            else if(txt_user.Text == "234" && txt_pass.Text == "234")
            {
                Form form_inicio = new IHomeAdmin();
                this.Hide();
                form_inicio.Show();
            }
            else if (txt_user.Text == "123" && txt_pass.Text == "123")
            {
                Form form_gerente = new IHomeGerente();
                this.Hide();
                form_gerente.Show();
            }
            else if (txt_user.Text == "vendedor1" && txt_pass.Text == "Vendedor123!")
            {
                Form form_vendedor = new Form_vendedor_init();
                this.Visible = false;
                form_vendedor.Show();
            }
            else
            {
                MessageBox.Show("Usuario y/o Contraseña incorrectas", "ERROR!",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information
               );
                txt_pass.Clear();
                txt_user.Clear();
                txt_user.Focus();
            }
        }

        */
    }
}