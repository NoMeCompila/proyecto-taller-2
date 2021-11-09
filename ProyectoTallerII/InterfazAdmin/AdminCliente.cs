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
using System.Data.SqlClient;

namespace ProyectoTallerII
{
    public partial class AdminCliente : Form
    {
        private string id = null;
        int fila;
        public AdminCliente()

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
            } else if (!ValidateEmail())
            {
                MessageBox.Show("Ingrese un correo válido",
                                "Error!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                txt_user_email.Focus();
                txt_user_email.Clear();
            } else if (validateAge() < 18)
            {
                MessageBox.Show("ICliente menor de edad, ingrese fecha válida",
                                "Error!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {
                if (MessageBox.Show("Seguro que desea guardar al nuevo cliente?",
                              "Guardar Datos!",
                              MessageBoxButtons.YesNo,
                              MessageBoxIcon.Question,
                              MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {

                    try
                    {
                        objetoCN.guardar_cliete(txt_user_nombre.Text,
                                             txt_user_apellido.Text,
                                             txt_user_dni.Text,
                                             txt_user_email.Text,
                                             txt_user_tel.Text,
                                             txt_user_adress.Text,
                                             dtp_user_date_birth.Text,
                                             combo_estado.Text);


                        MessageBox.Show("Cliente guardado correctamente", "GUARDADO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //mostrar_client_admin(); //se actualioza la vista del DGV

                        this.mostrar_busqueda();

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
                MessageBox.Show("Cliente menor de edad, ingrese fecha válida",
                                "Error!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {
                if (MessageBox.Show("Seguro que desea modificar los datos del cliente?",
                             "Guardar Datos!",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question,
                             MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    objetoCN.actualizar_cliente_admin
                    (
                            txt_user_nombre.Text,
                            txt_user_apellido.Text,
                            txt_user_dni.Text,
                            txt_user_email.Text,
                            txt_user_tel.Text,
                            txt_user_adress.Text,
                            dtp_user_date_birth.Text,
                            combo_estado.Text,
                            Convert.ToInt32(id)
                     );

                    //se muestra un mensaje para informar al usuario
                    MessageBox.Show("los datos del cliente fueron actualizados correctamente", "ACTUALIZADO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //mostrar_client_admin(); //se actualioza la vista del DGV
                    mostrar_busqueda();
                    limpiar(); // se limpian los textbox
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
        private void mostrar_client_admin()
        {
            //instancia de un objeto cliente
            cn_clientes cliente_obj = new cn_clientes();
            dataG_usuarios.DataSource = cliente_obj.mostrar_clientes_admin();
        }





        private void Form_vendedor_clientes_Load(object sender, EventArgs e)
        {
            //mostrar_client_admin();
            mostrar_busqueda();
        }




        private void dataG_usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_user_nombre.Text = dataG_usuarios.CurrentRow.Cells["nombre"].Value.ToString();
            txt_user_apellido.Text = dataG_usuarios.CurrentRow.Cells["apellido"].Value.ToString();
            txt_user_dni.Text = dataG_usuarios.CurrentRow.Cells["dni"].Value.ToString();
            txt_user_email.Text = dataG_usuarios.CurrentRow.Cells["email"].Value.ToString();
            txt_user_tel.Text = dataG_usuarios.CurrentRow.Cells["teléfono"].Value.ToString();
            txt_user_adress.Text = dataG_usuarios.CurrentRow.Cells["dirección"].Value.ToString();
            dtp_user_date_birth.Text = dataG_usuarios.CurrentRow.Cells["fecha nacimiento"].Value.ToString();
            combo_estado.Text = dataG_usuarios.CurrentRow.Cells["estado"].Value.ToString();
            id = dataG_usuarios.CurrentRow.Cells["id"].Value.ToString();

            btn_user_agregar.Enabled = false;
            btn_user_modificar.Enabled = true;
            btn_user_elimiar.Enabled = true;
        }

        private void btn_user_elimiar_Click(object sender, EventArgs e)
        {
            id = dataG_usuarios.CurrentRow.Cells["id"].Value.ToString(); //IMPORTATNE: darle valor al id para especificar que dato se quiere actualizar
            if (MessageBox.Show("Seguro que desea eliminar al cliente?",
                             "Eliminar Datos!",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question,
                             MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                objetoCN.eliminar_cliente_admin(id);
                MessageBox.Show("Cliente Eliminado correctamente", "ELIMINADO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //mostrar_client_admin(); //se actualioza la vista del DGV
                mostrar_busqueda();

                limpiar();
            }
            else
            {
                limpiar();
            }
        }

        //codigo para el buscador dinámico
        //objeto donde se almacenan los resultados de la busqueda dinámica
        DataSet resultados = new DataSet();

        // objeto donde se aplican los fitros
        DataView filtro;
        public void leer_datos(string query, ref DataSet setprincipal, string tabla)
        {
                resultados.Clear();  // MUY IMPORTANTE LIMPIAR LOS RESULTADOS PARA EVITAR SORBECARGAR EL DATAGRIDVIEW
                string cadena = "Server=DESKTOP-C7M4JOU;Database=JOYERIA;Integrated Security=true";
                SqlConnection cn = new SqlConnection(cadena);
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.Clear();
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                
                da.Fill(setprincipal, tabla);
                da.Dispose();
                cn.Close();
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_buscar_KeyUp(object sender, KeyEventArgs e)
        {
            string salida_datos = "";
            string[] palabras_busqueda = this.txt_buscar.Text.Split(' ');

            foreach(string palabra in palabras_busqueda)
            {
                if (salida_datos.Length == 0)
                {
                    salida_datos = "(nombre LIKE '%" + palabra +
                        "%' OR apellido LIKE '%" + palabra +
                        "%' OR dni LIKE '%" +palabra+ "%')";
                }
                else
                {
                    salida_datos += "AND (nombre LIKE '%" + palabra +
                        "%' OR apellido LIKE '%" + palabra +
                        "%' OR dni LIKE '%" + palabra + "%')";
                }
            }

            this.filtro.RowFilter = salida_datos;
        }

        private void mostrar_busqueda()
        {

            //mostrar_client_admin();
            this.leer_datos("SELECT " +
                "Cliente.id_cliente as ID, " +
                "Cliente.nombre AS NOMBRE, " +
                "Cliente.apellido AS APELLIDO, " +
                "Cliente.dni AS DNI, " +
                "Cliente.email AS EMAIL, " +
                "Cliente.telefono AS TELÉFONO, " +
                "Cliente.direccion AS DIRECCIÓN, " +
                "Cliente.fecha_nac AS " +
                "'FECHA NACIMIENTO', " +
                "Cliente.estado AS ESTADO   FROM Cliente", ref resultados, "Cliente");
            //probando buscador
            this.filtro = ((DataTable)resultados.Tables["Cliente"]).DefaultView;

            //igualamos el datagridview al resultado del filtro
            this.dataG_usuarios.DataSource = filtro;
        }


        private void txt_user_dni_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
