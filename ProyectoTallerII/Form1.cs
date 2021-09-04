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

        

        private void pb_menu_Click(object sender, EventArgs e)
        {

        }

        private void wrapper_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if (!char.IsControl(e.KeyChar) &&  !char.IsLetter(e.KeyChar))  
            {
                e.Handled = true;
            }*/
            
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt_pass.Focus();
            }
        }

   

        private void txt_user_Enter(object sender, EventArgs e)
        {
            if(txt_user.Text == "Usuario")
            {
                txt_user.Text = "";

                txt_user.ForeColor = Color.Black;
            }
        }

        private void txt_user_Leave(object sender, EventArgs e)
        {


            if (txt_user.Text == "")
            {
                txt_user.Text = "Usuario";

                txt_user.ForeColor = Color.Silver;
            }


        }

        private void txt_pass_Enter(object sender, EventArgs e)
        {
            if (txt_pass.Text == "Contraseña")
            {
                txt_pass.Text = "";

                txt_pass.ForeColor = Color.Black;
                txt_pass.UseSystemPasswordChar = true;
            }
        }
        
        private void txt_pass_Leave(object sender, EventArgs e)
        {
            if (txt_pass.Text == "" || txt_pass.Text == "●●●●●●●●●●")
            {
                txt_pass.Text = "Contraseña";

                txt_pass.ForeColor = Color.Silver;
                txt_pass.UseSystemPasswordChar = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
         
        }
    }
}
