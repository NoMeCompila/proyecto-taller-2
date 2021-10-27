﻿using System;
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
    public partial class Form_usuarios : Form
    {
        int fila;
        public Form_usuarios()
        {
            InitializeComponent();
            limpiar();
        }

        //limpiar es una funcion que pone a todos los valores por defecto, es decir vacia todos los textBox
        // pone al dropdown en su pirmer valor "Administrador" y setea el datetimepicker en la fecha actual


        void limpiar()
        {
            btn_modificar.Enabled = false;

            txt_user_nombre.Clear();  txt_user_apellido.Clear();   txt_user_dni.Clear();
            txt_user_usuario.Clear(); txt_user_contraseña.Clear(); txt_user_email.Clear();
            drd_user_perfil.SelectedIndex = 0;
            txt_user_tel.Clear(); txt_user_adress.Clear();
            dtp_user_date_birth.Value = DateTime.Now;
            
            btn_user_agregar.Enabled = true;
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

        private int validateAge()
        {
            DateTime fechaHoy = DateTime.Today;
            int edad = fechaHoy.Year - dtp_user_date_birth.Value.Year;
            return edad;
        }


        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;//MUY IMPORTANTE
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
                    else
                    {
                        limpiar();
                    }
                }
            }
            catch(NullReferenceException)
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
            limpiar();
        }


        private void btn_user_agregar_Click(object sender, EventArgs e)
        {
            if (txt_user_nombre.Text == "" || txt_user_apellido.Text == "" || txt_user_dni.Text == "" ||
                txt_user_usuario.Text == "" || txt_user_contraseña.Text == "" || txt_user_email.Text == "" ||
                drd_user_perfil.Text == "" || txt_user_tel.Text == "" || txt_user_adress.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos!", "ERROR!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                );


            }
            //variable para guardar el texto ingresado por eltextbox
            var contraseña = txt_user_contraseña.Text;
            var dni = txt_user_dni.Text;
            var usuario1 = txt_user_usuario.Text;
            var email1 = txt_user_email.Text;
            //variable para generar una nueva expresion regular quye verifica que elñ texto ingresado contenga al menos un numero
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperCase = new Regex(@"[A-Z]+");
            var hasLowerCase = new Regex(@"[a-z]+");
            //\|!#$%&/()=?»«@£§€{}.-;'<>_,
            var hasSymbols = new Regex(@"[\|!#$%&/()=?»«@£§€{}.;'<>_,]+");
            //var emailFormat = new Regex(@"[^[^@\s] +@[^@\s] +\.[^@\s]+$]+");
            //@"(@)(.+)$"

            if (!hasNumber.IsMatch(contraseña))
            {
                MessageBox.Show("La contraseña debe incluir por lo menos 1 número",
                                "Error!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);

                txt_user_contraseña.Focus();
                txt_user_contraseña.Clear();
                return;

            } else if (!hasUpperCase.IsMatch(contraseña))
            {
                MessageBox.Show("La contraseña debe incluir por lo menos una letra mayúscula",
                                "Error!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);

                txt_user_contraseña.Focus();
                txt_user_contraseña.Clear();
                return;
            }
            else if (!hasLowerCase.IsMatch(contraseña))
            {
                MessageBox.Show("La contraseña debe incluir por lo menos una letra minúscula",
                                "Error!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);

                txt_user_contraseña.Focus();
                txt_user_contraseña.Clear();
                return;
            }
            else if (!hasSymbols.IsMatch(contraseña))
            {
                MessageBox.Show("La contraseña debe incluir por lo menos un símbnolo",
                                "Error!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);

                txt_user_contraseña.Focus();
                txt_user_contraseña.Clear();
                return;
            }
            else if (contraseña.Length < 8)
            {
                MessageBox.Show("La contraseña debe tener por lo menos 8 caracteres",
                                "Error!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);

                txt_user_contraseña.Focus();
                txt_user_contraseña.Clear();
                return;
            }
            else if (contraseña.Length > 16)
            {
                MessageBox.Show("La contraseña debe tener un máximo de 15 caractere",
                                "Error!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);

                txt_user_contraseña.Focus();
                txt_user_contraseña.Clear();
                return;
            }
            else if (dni.Length < 7)
            {
                MessageBox.Show("El DNI debe tener un mínimo de 7 caractere",
                                "Error!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);

                txt_user_contraseña.Focus();
                txt_user_dni.Clear();
                return;
            }
            else if (usuario1.Length < 3)
            {
                MessageBox.Show("El nombre de usuario debe tener un mínimo de 3 caracteres",
                                "Error!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);

                txt_user_usuario.Focus();
                txt_user_usuario.Clear();
                return;
            } else if (!ValidateEmail())
            {
                MessageBox.Show("Ingrese un correo válido",
                                "Error!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                txt_user_email.Focus();
                txt_user_email.Clear();
            }
            else if (validateAge()<18)
            {
                MessageBox.Show("Usuario menor de edad, ingrese fecha válida",
                                "Error!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                dtp_user_date_birth.Value = DateTime.Now;
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
                    dtg_usuarios.Rows[writeRow].Cells[3].Value = txt_user_usuario.Text;
                    dtg_usuarios.Rows[writeRow].Cells[4].Value = txt_user_contraseña.Text;
                    dtg_usuarios.Rows[writeRow].Cells[5].Value = txt_user_email.Text;
                    dtg_usuarios.Rows[writeRow].Cells[6].Value = drd_user_perfil.Text;
                    dtg_usuarios.Rows[writeRow].Cells[7].Value = txt_user_tel.Text;
                    dtg_usuarios.Rows[writeRow].Cells[8].Value = txt_user_adress.Text;
                    dtg_usuarios.Rows[writeRow].Cells[9].Value = dtp_user_date_birth.Text;


                    limpiar();
                }
                else
                {
                    limpiar();
                }
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
                txt_user_usuario.Text = dtg_usuarios[3, fila].Value.ToString();
                txt_user_contraseña.Text = dtg_usuarios[4, fila].Value.ToString();
                txt_user_email.Text = dtg_usuarios[5, fila].Value.ToString();
                drd_user_perfil.Text = dtg_usuarios[6, fila].Value.ToString();
                txt_user_tel.Text = dtg_usuarios[7, fila].Value.ToString();
                txt_user_adress.Text = dtg_usuarios[8, fila].Value.ToString();
                dtp_user_date_birth.Text = dtg_usuarios[9, fila].Value.ToString();

                btn_user_agregar.Enabled = false;
                btn_modificar.Enabled = true;


            }
            catch (NullReferenceException)
            {
                MessageBox.Show("La tabla está vacía, inserte datos primero", "ERROR!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                );
            }
           
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {

            if (txt_user_nombre.Text == "" || txt_user_apellido.Text == "" || txt_user_dni.Text == "" ||
                txt_user_usuario.Text == "" || txt_user_contraseña.Text == "" || txt_user_email.Text == "" ||
                drd_user_perfil.Text == "" || txt_user_tel.Text == "" || txt_user_adress.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos!", "ERROR!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                );
            }

            var contraseña = txt_user_contraseña.Text;
            var dni_usuario = txt_user_dni.Text;
            var usuario1 = txt_user_usuario.Text;

            //variable para generar una nueva expresion regular quye verifica que elñ texto ingresado contenga al menos un numero
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperCase = new Regex(@"[A-Z]+");
            var hasLowerCase = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[\|!#$%&/()=?»«@£§€{}.;'<>_,]+");
            
            if (!hasNumber.IsMatch(contraseña))
            {
                MessageBox.Show("La contraseña debe incluir por lo menos 1 número",
                                "Error!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                
                txt_user_contraseña.Focus();
                txt_user_contraseña.Clear();
                return;
            }else if (!hasUpperCase.IsMatch(contraseña))
            {
                MessageBox.Show("La contraseña debe incluir por lo menos una letra mayúscula",
                                "Error!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                
                txt_user_contraseña.Focus();
                return;
            }
            else if (!hasLowerCase.IsMatch(contraseña))
            {
                MessageBox.Show("La contraseña debe incluir por lo menos una letra minúscula",
                                "Error!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                txt_user_contraseña.Focus();
                txt_user_contraseña.Clear();
                return;
            }
            else if (!hasSymbols.IsMatch(contraseña))
            {
                MessageBox.Show("La contraseña debe incluir por lo menos un símbolo",
                                "Error!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                txt_user_contraseña.Focus();
                txt_user_contraseña.Clear();
                return;
            }
            else if (contraseña.Length < 8)
            {
                MessageBox.Show("La contraseña debe incluir como mínimo 8 caracteres",
                                "Error!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                txt_user_contraseña.Focus();
                txt_user_contraseña.Clear();
                return;
            }
            else if (contraseña.Length > 16)
            {
                MessageBox.Show("La contraseña debe tener un máximo de 15 caractere",
                                "Error!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                txt_user_contraseña.Focus();
                txt_user_contraseña.Clear();
                return;
            }
            else if (dni_usuario.Length < 7)
            {
                MessageBox.Show("El DNI debe tener un mínimo de 7 caractere",
                                "Error!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);

                txt_user_dni.Focus();
                txt_user_dni.Clear();
                return;
            }
            else if (usuario1.Length < 3)
            {
                MessageBox.Show("El nombre de usuario debe tener un mínimo de 3 caracteres",
                                "Error!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);

                txt_user_usuario.Focus();
                txt_user_usuario.Clear();
                return;
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
                MessageBox.Show("Usuario menor de edad, ingrese fecha válida",
                                "Error!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                dtp_user_date_birth.Value = DateTime.Now;
            }
            else
            {

                string name, surname, dni, user, pass, email, perfil, tel, adress, birth;

                name = txt_user_nombre.Text;
                surname = txt_user_apellido.Text;
                dni = txt_user_dni.Text;
                user = txt_user_usuario.Text;
                pass = txt_user_contraseña.Text;
                email = txt_user_email.Text;
                perfil = drd_user_perfil.Text;
                tel = txt_user_tel.Text;
                adress = txt_user_adress.Text;
                birth = dtp_user_date_birth.Text;

                dtg_usuarios[0, fila].Value = txt_user_nombre.Text;
                dtg_usuarios[1, fila].Value = txt_user_apellido.Text;
                dtg_usuarios[2, fila].Value = txt_user_dni.Text;
                dtg_usuarios[3, fila].Value = txt_user_usuario.Text;
                dtg_usuarios[4, fila].Value = txt_user_contraseña.Text;
                dtg_usuarios[5, fila].Value = txt_user_email.Text;
                dtg_usuarios[6, fila].Value = drd_user_perfil.Text;
                dtg_usuarios[7, fila].Value = txt_user_tel.Text;
                dtg_usuarios[8, fila].Value = txt_user_adress.Text;
                dtg_usuarios[9, fila].Value = dtp_user_date_birth.Text;

                limpiar();

            }
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

        private void txt_user_nombre_TextChanged(object sender, EventArgs e)
        {
            txt_user_nombre.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_user_nombre.Text);
            txt_user_nombre.SelectionStart = txt_user_nombre.Text.Length;
        }

        private void txt_user_apellido_TextChanged(object sender, EventArgs e)
        {
            txt_user_apellido.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_user_apellido.Text);
            txt_user_apellido.SelectionStart = txt_user_apellido.Text.Length;
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

        private void txt_user_dni_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_user_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt_user_usuario.Focus();
            }
        }

        private void txt_user_usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt_user_contraseña.Focus();
            }
            
        }

        private void txt_user_contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt_user_email.Focus();
            }
        }

        private void txt_user_email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt_user_tel.Focus();
            }
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

        private void txt_user_adress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}