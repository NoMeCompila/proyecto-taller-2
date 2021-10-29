using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ProyectoTallerII
{
    public partial class IVendedorCliente : Form
    {
        int fila;
        public IVendedorCliente()

        {
            
            InitializeComponent();
            limpiar();
        }

        void limpiar()
        {
            btn_user_modificar.Enabled = false;

            txt_user_nombre.Clear();
            txt_user_apellido.Clear();
            txt_user_dni.Clear();
            txt_user_email.Clear();
            txt_user_tel.Clear();
            txt_user_adress.Clear(); 
            dtp_user_date_birth.Value = DateTime.Now;

            btn_user_agregar.Enabled = true;

        }

        private int validateAge()
        {
            DateTime fechaHoy = DateTime.Today;
            int edad = fechaHoy.Year - dtp_user_date_birth.Value.Year;
            return edad;
        }

        private void txt_user_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt_user_apellido.Focus();
            }
        }

        private void txt_user_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt_user_dni.Focus();
            }
        }





        private void txt_user_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt_user_email.Focus();
            }
        }



        private bool ValidateEmail()
        {
            string email = txt_user_email.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        private void txt_user_email_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_user_tel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt_user_adress.Focus();
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btn_user_agregar_Click(object sender, EventArgs e)
        {
            if (txt_user_nombre.Text == "" || txt_user_apellido.Text == "" ||
                txt_user_dni.Text == "" || txt_user_email.Text == "" ||
                txt_user_tel.Text == "" || txt_user_adress.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos!", "ERROR!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                );
            }else if (!ValidateEmail())
            {
                MessageBox.Show("Ingrese un correo válido",
                                "Error!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                txt_user_email.Focus();
                txt_user_email.Clear();
            }else if (validateAge() < 18)
            {
                MessageBox.Show("ICliente menor de edad, ingrese fecha válida",
                                "Error!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {
                if (MessageBox.Show("Seguro que desea guardar?",
                              "Guardar Datos!",
                              MessageBoxButtons.YesNo,
                              MessageBoxIcon.Question,
                              MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    int writeRow = dtg_usuarios.Rows.Count;
                    dtg_usuarios.Rows.Add(1);

                    dtg_usuarios.Rows[writeRow].Cells[0].Value = txt_user_nombre.Text;
                    dtg_usuarios.Rows[writeRow].Cells[1].Value = txt_user_apellido.Text;
                    dtg_usuarios.Rows[writeRow].Cells[2].Value = txt_user_dni.Text;
                    dtg_usuarios.Rows[writeRow].Cells[3].Value = txt_user_email.Text;
                    dtg_usuarios.Rows[writeRow].Cells[4].Value = txt_user_tel.Text;
                    dtg_usuarios.Rows[writeRow].Cells[5].Value = txt_user_adress.Text;
                    dtg_usuarios.Rows[writeRow].Cells[6].Value = dtp_user_date_birth.Text;
                    


                    limpiar();
                }
                else
                {
                    limpiar();
                }
            }
        }

        private void dtg_usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            Eliminar.Text = "Eliminar";
            if (e.RowIndex == -1) return;//MUY IMPORTANTE
            
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
                    else
                    {
                        limpiar();
                    }
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("La tabla está vacía, inserte datos primero", "ERROR!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                );
            }
        }

        private void txt_user_nombre_TextChange(object sender, EventArgs e)
        {
            txt_user_nombre.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_user_nombre.Text);
            txt_user_nombre.SelectionStart = txt_user_nombre.Text.Length;
        }

        private void txt_user_apellido_TextChanged(object sender, EventArgs e)
        {
            txt_user_apellido.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_user_apellido.Text);
            txt_user_apellido.SelectionStart = txt_user_apellido.Text.Length;
        }

        private void txt_user_email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt_user_tel.Focus();
            }
        }

        private void dtg_usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            try
            {
                fila = dtg_usuarios.CurrentRow.Index;



                txt_user_nombre.Text = dtg_usuarios[0, fila].Value.ToString();
                txt_user_apellido.Text = dtg_usuarios[1, fila].Value.ToString();
                txt_user_dni.Text = dtg_usuarios[2, fila].Value.ToString();
                txt_user_email.Text = dtg_usuarios[3, fila].Value.ToString();
                txt_user_tel.Text = dtg_usuarios[4, fila].Value.ToString();
                txt_user_adress.Text = dtg_usuarios[5, fila].Value.ToString();
                dtp_user_date_birth.Text = dtg_usuarios[6, fila].Value.ToString();
                

                btn_user_agregar.Enabled = false;
                btn_user_modificar.Enabled = true;


            }
            catch (NullReferenceException)
            {
                MessageBox.Show("La tabla está vacía, inserte datos primero", "ERROR!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                );
            }

        }

        private void btn_user_modificar_Click(object sender, EventArgs e)
        {
            if (txt_user_nombre.Text == "" || txt_user_apellido.Text == "" ||
               txt_user_dni.Text == "" || txt_user_email.Text == "" ||
               txt_user_tel.Text == "" || txt_user_adress.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos!", "ERROR!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                );
            }
            else if (!ValidateEmail())
            {
                MessageBox.Show("Ingrese un correo válido",
                                "Error!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                txt_user_email.Focus();
                txt_user_email.Clear();
            }
            else if (validateAge() < 18)
            {
                MessageBox.Show("ICliente menor de edad, ingrese fecha válida",
                                "Error!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {
                if (MessageBox.Show("Seguro que desea modificar?",
                             "Guardar Datos!",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question,
                             MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {


                    dtg_usuarios[0, fila].Value = txt_user_nombre.Text;
                    dtg_usuarios[1, fila].Value = txt_user_apellido.Text;
                    dtg_usuarios[2, fila].Value = txt_user_dni.Text;
                    dtg_usuarios[3, fila].Value = txt_user_email.Text;
                    dtg_usuarios[4, fila].Value = txt_user_tel.Text;
                    dtg_usuarios[5, fila].Value = txt_user_adress.Text;
                    dtg_usuarios[6, fila].Value = dtp_user_date_birth.Text;

                    limpiar();
                }
                else
                {
                    limpiar();
                }
            }
        }

        private void Form_vendedor_clientes_Load(object sender, EventArgs e)
        {

        }
    }
}
