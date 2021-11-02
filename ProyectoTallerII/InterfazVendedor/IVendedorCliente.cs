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
using CapaNegocio;

namespace ProyectoTallerII
{
    public partial class IVendedorCliente : Form
    {
        private string id = null;
        int fila;
        public IVendedorCliente()

        {
            
            InitializeComponent();
            limpiar();
        }

        void limpiar()
        {
            btn_user_elimiar.Enabled = false;
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

                    try
                    {
                        objetoCN.insertar_cliete(txt_user_nombre.Text,
                                             txt_user_apellido.Text,
                                             txt_user_dni.Text,
                                             txt_user_email.Text,
                                             txt_user_tel.Text,
                                             txt_user_adress.Text,
                                             dtp_user_date_birth.Text);


                        MessageBox.Show("Elemento insertado", "Insertado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mostrar_client(); //se actualioza la vista del DGV

                        limpiar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo insertar: " + ex, "ERROR", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                    }


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
                
                

                btn_user_agregar.Enabled = false;
                btn_user_elimiar.Enabled = true;
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
                    objetoCN.actualizar_cliet(
                            txt_user_nombre.Text,
                            txt_user_apellido.Text,
                            txt_user_dni.Text,
                            txt_user_email.Text,
                            txt_user_tel.Text,
                            txt_user_adress.Text,
                            dtp_user_date_birth.Text,
                            Convert.ToInt32(id));
                    MessageBox.Show("Elemento Actualizado", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    mostrar_client(); //se actualioza la vista del DGV

                    limpiar();



                    limpiar();
                }
                else
                {
                    limpiar();
                }
            }
        }

        //instancia de un objeto cliente
        cn_clientes objetoCN = new cn_clientes();


        //funcion para cargar el datagrid view del formulario
        private void mostrar_client()
        {
            //instancia de un objeto cliente
            cn_clientes cliente_obj = new cn_clientes();
            dataG_usuarios.DataSource = cliente_obj.mostrar_clientes();

        }


        private void Form_vendedor_clientes_Load(object sender, EventArgs e)
        {
            mostrar_client();
        }

        private void dataG_usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_user_nombre.Text = dataG_usuarios.CurrentRow.Cells["nombre"].Value.ToString();
            txt_user_apellido.Text = dataG_usuarios.CurrentRow.Cells["apellido"].Value.ToString();
            txt_user_dni.Text = dataG_usuarios.CurrentRow.Cells["dni"].Value.ToString();
            txt_user_email.Text = dataG_usuarios.CurrentRow.Cells["email"].Value.ToString();
            txt_user_tel.Text = dataG_usuarios.CurrentRow.Cells["telefono"].Value.ToString();
            txt_user_adress.Text = dataG_usuarios.CurrentRow.Cells["dirección"].Value.ToString();
            dtp_user_date_birth.Text = dataG_usuarios.CurrentRow.Cells["fecha nacimiento"].Value.ToString();
            id = dataG_usuarios.CurrentRow.Cells["id"].Value.ToString();

            btn_user_agregar.Enabled = false;
            btn_user_modificar.Enabled = true;
            btn_user_elimiar.Enabled = true;
        }

        private void btn_user_elimiar_Click(object sender, EventArgs e)
        {
            id = dataG_usuarios.CurrentRow.Cells["id_cliente"].Value.ToString();
            if (MessageBox.Show("Seguro que desea eliminar?",
                             "Eliminar Datos!",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question,
                             MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                objetoCN.eliminar_client(id);
                MessageBox.Show("Elemento Eliminado", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mostrar_client(); //se actualioza la vista del DGV
            }
            else
            {
                limpiar();
            }

                

          

        }
    }
}
