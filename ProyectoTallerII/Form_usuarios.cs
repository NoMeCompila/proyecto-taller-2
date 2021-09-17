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
    public partial class Form_usuarios : Form
    {
        int fila;
        public Form_usuarios()
        {
            InitializeComponent();
            limpiar();
        }

        void limpiar()
        {
            btn_modificar.Enabled = false;
            txt_user_nombre.Clear(); txt_user_apellido.Clear();
            txt_user_usuario.Clear(); txt_user_contraseña.Clear();
            txt_user_email.Clear(); txt_user_perfil.Clear();
            txt_user_estado.Clear(); txt_user_descripcion.Clear();
            btn_user_agregar.Enabled = true;
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Eliminar.Text = "Eliminar";

            try
            {
                int posicion = dtg_usuarios.CurrentRow.Index;

                if (dtg_usuarios.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    if (MessageBox.Show("¿Seguro que quiere eliminar?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        dtg_usuarios.Rows.RemoveAt(posicion);
                        limpiar();
                    }
                }
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show("La tabla está vacía, inserte datos primero", "ERROR!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                );
            }

            


            

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void btn_user_limpiar_Click(object sender, EventArgs e)
        {
            if (txt_user_nombre.Text  == "" || txt_user_apellido.Text    == "" ||
                txt_user_usuario.Text == "" || txt_user_contraseña.Text  == "" ||
                txt_user_email.Text   == "" || txt_user_perfil.Text      == "" ||
                txt_user_estado.Text  == "" || txt_user_descripcion.Text == ""  )
            {
                MessageBox.Show("Campos vacíos no se puede limpiar!", "ERROR!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                );
            }
            else
            {
                limpiar();
            }
        }

        private void btn_user_agregar_Click(object sender, EventArgs e)
        {
            if (txt_user_nombre.Text  == "" || txt_user_apellido.Text    == "" ||
                txt_user_usuario.Text == "" || txt_user_contraseña.Text  == "" ||
                txt_user_email.Text   == "" || txt_user_perfil.Text      == "" ||
                txt_user_estado.Text  == "" || txt_user_descripcion.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos!", "ERROR!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                );
            }
            else
            {
                int writeRow = dtg_usuarios.Rows.Count;
                dtg_usuarios.Rows.Add(1);
                
                dtg_usuarios.Rows[writeRow].Cells[0].Value = txt_user_nombre.Text;
                dtg_usuarios.Rows[writeRow].Cells[1].Value = txt_user_apellido.Text;
                dtg_usuarios.Rows[writeRow].Cells[2].Value = txt_user_usuario.Text;
                dtg_usuarios.Rows[writeRow].Cells[3].Value = txt_user_contraseña.Text;
                dtg_usuarios.Rows[writeRow].Cells[4].Value = txt_user_email.Text;
                dtg_usuarios.Rows[writeRow].Cells[5].Value = txt_user_perfil.Text;
                dtg_usuarios.Rows[writeRow].Cells[6].Value = txt_user_descripcion.Text;
                dtg_usuarios.Rows[writeRow].Cells[7].Value = txt_user_estado.Text;


                limpiar();
            }
        }

        private void dtg_usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                fila = dtg_usuarios.CurrentRow.Index;

                txt_user_nombre.Text = dtg_usuarios[0, fila].Value.ToString();
                txt_user_apellido.Text = dtg_usuarios[1, fila].Value.ToString();
                txt_user_usuario.Text = dtg_usuarios[2, fila].Value.ToString();
                txt_user_contraseña.Text = dtg_usuarios[3, fila].Value.ToString();
                txt_user_email.Text = dtg_usuarios[4, fila].Value.ToString();
                txt_user_perfil.Text = dtg_usuarios[5, fila].Value.ToString();
                txt_user_descripcion.Text = dtg_usuarios[6, fila].Value.ToString();
                txt_user_estado.Text = dtg_usuarios[7, fila].Value.ToString();
                //MessageBox.Show(position+""); System.NullReferenceException

                btn_user_agregar.Enabled = false;
                btn_modificar.Enabled = true;


            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("La tabla está vacía, inserte datos primero", "ERROR!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                );
            }
           
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            
            string name, surname, user, pass, email, perfil, desc, status;
            name = txt_user_nombre.Text;
            surname = txt_user_apellido.Text;
            user = txt_user_usuario.Text;
            pass = txt_user_contraseña.Text;
            email = txt_user_email.Text;
            perfil = txt_user_perfil.Text;
            desc = txt_user_descripcion.Text;
            status = txt_user_estado.Text;

            dtg_usuarios[0, fila].Value = txt_user_nombre.Text;
            dtg_usuarios[1, fila].Value = txt_user_apellido.Text;
            dtg_usuarios[2, fila].Value = txt_user_usuario.Text;
            dtg_usuarios[3, fila].Value = txt_user_contraseña.Text;
            dtg_usuarios[4, fila].Value = txt_user_email.Text;
            dtg_usuarios[5, fila].Value = txt_user_perfil.Text;
            dtg_usuarios[6, fila].Value = txt_user_descripcion.Text;
            dtg_usuarios[7, fila].Value = txt_user_estado.Text;



            limpiar();
        }
    }
}
