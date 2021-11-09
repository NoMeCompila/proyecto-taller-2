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
using System.Data;
using System.Data.SqlClient;

namespace ProyectoTallerII
{
    public partial class Form_usuarios : Form
    {
        private string id = null;
        int fila;
        public Form_usuarios()
        {
            InitializeComponent();
            limpiar();
        }

        //limpiar es una funcion que pone a todos los valores por defecto, es decir vacia todos los textBox
        // pone al dropdown en su pirmer valor "Administrador" y setea el datetimepicker en la fecha actual

        cn_usuarios objetoCN = new cn_usuarios();
        void limpiar()
        {
            btn_modificar.Enabled = false;
            btn_user_elimiar.Enabled = false;

            txt_user_nombre.Clear();  txt_user_apellido.Clear();   txt_user_dni.Clear();
            txt_user_usuario.Clear(); txt_user_contraseña.Clear(); txt_user_email.Clear();
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

        // funcion que evalúa si el usuario es menor de eddad (se debe ser mayor para poder trabajar en el sistema)
        private int validateAge()
        {
            DateTime fechaHoy = DateTime.Today;
            int edad = fechaHoy.Year - dtp_user_date_birth.Value.Year;
            return edad;
        }


        
        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void btn_user_limpiar_Click(object sender, EventArgs e)
        {
            this.limpiar();
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

            }
            else if (!hasUpperCase.IsMatch(contraseña))
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
                if (MessageBox.Show("Seguro que desea modificar al usuario?",
                              "Modificar Datos!",
                              MessageBoxButtons.YesNo,
                              MessageBoxIcon.Question,
                              MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    try
                    {
                        objetoCN.actualizar_usuario(
                                             txt_user_nombre.Text,
                                             txt_user_apellido.Text,
                                             txt_user_dni.Text,
                                             txt_user_usuario.Text,
                                             txt_user_contraseña.Text,
                                             txt_user_email.Text,
                                             Convert.ToInt32(drd_user_perfil.SelectedValue),
                                             txt_user_tel.Text,
                                             txt_user_adress.Text,
                                             dtp_user_date_birth.Text,
                                             Convert.ToInt32(id));


                        MessageBox.Show("Usuario actualizado correctamente", "ACTUALIZADO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //mostrar_client_admin(); //se actualioza la vista del DGV
                        this.mostrar_busqueda();
                        this.limpiar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo modificar: " + ex, "ERROR", MessageBoxButtons.OK,
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
                if (MessageBox.Show("Seguro que desea guardar al nuevo usuario?",
                              "Guardar Datos!",
                              MessageBoxButtons.YesNo,
                              MessageBoxIcon.Question,
                              MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    try
                    {
                        objetoCN.guardar_usuario(
                                             txt_user_nombre.Text,
                                             txt_user_apellido.Text,
                                             txt_user_dni.Text,
                                             txt_user_usuario.Text,
                                             txt_user_contraseña.Text,
                                             txt_user_email.Text,
                                             Convert.ToInt32(drd_user_perfil.SelectedValue),
                                             txt_user_tel.Text,
                                             txt_user_adress.Text,
                                             dtp_user_date_birth.Text);


                        MessageBox.Show("Usuario guardado correctamente", "GUARDADO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //mostrar_client_admin(); //se actualioza la vista del DGV
                        this.mostrar_busqueda();
                        this.limpiar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo insertar: " + ex, "ERROR", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                    }


                    this.limpiar();
                }
                else
                {
                    this.limpiar();
                }
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

        private void listar_perfiles()
        {
            cn_perfiles objPer = new cn_perfiles();
            drd_user_perfil.DataSource = objPer.mostrar_perfiles();
            drd_user_perfil.DisplayMember = "descripcion";
            drd_user_perfil.ValueMember = "id_perfil";
        }

        private void mostrar_usuarios()
        {
            //instancia de un objeto cliente
            cn_usuarios cliente_obj = new cn_usuarios();
            dgv_usuarios.DataSource = cliente_obj.mostrar_usuarios();
        }


        private void Form_usuarios_Load(object sender, EventArgs e)
        {
            this.mostrar_busqueda();
            this.listar_perfiles();
        }

        private void dgv_usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_user_nombre.Text = dgv_usuarios.CurrentRow.Cells["nombre"].Value.ToString();
            txt_user_apellido.Text = dgv_usuarios.CurrentRow.Cells["apellido"].Value.ToString();
            txt_user_dni.Text = dgv_usuarios.CurrentRow.Cells["dni"].Value.ToString();
            txt_user_usuario.Text = dgv_usuarios.CurrentRow.Cells["usuario"].Value.ToString();
            txt_user_contraseña.Text = dgv_usuarios.CurrentRow.Cells["contraseña"].Value.ToString();
            txt_user_email.Text = dgv_usuarios.CurrentRow.Cells["email"].Value.ToString();
            drd_user_perfil.Text = dgv_usuarios.CurrentRow.Cells["perfil"].Value.ToString();
            txt_user_tel.Text = dgv_usuarios.CurrentRow.Cells["teléfono"].Value.ToString();
            txt_user_adress.Text = dgv_usuarios.CurrentRow.Cells["dirección"].Value.ToString();
            dtp_user_date_birth.Text = dgv_usuarios.CurrentRow.Cells["fecha nacimiento"].Value.ToString();
            id = dgv_usuarios.CurrentRow.Cells["id"].Value.ToString();

            btn_user_agregar.Enabled = false;
            btn_modificar.Enabled = true;
            btn_user_elimiar.Enabled = true;
        }

        private void btn_user_elimiar_Click(object sender, EventArgs e)
        {
            id = dgv_usuarios.CurrentRow.Cells["id"].Value.ToString(); //IMPORTATNE: darle valor al id para especificar que dato se quiere actualizar
            if (MessageBox.Show("Seguro que desea eliminar al usuario?",
                             "ELIMINAR!",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question,
                             MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                objetoCN.eliminar_usuario(id);
                MessageBox.Show("Usuario Eliminado correctamente", "ELIMINADO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //mostrar_client_admin(); //se actualioza la vista del DGV
                this.mostrar_busqueda();
                this.limpiar();
            }
            else
            {
                MessageBox.Show("Eliminacion Cancelada!", "Cancelado!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.limpiar();
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

        private void txt_buscar_KeyUp(object sender, KeyEventArgs e)
        {
            string salida_datos = "";
            string[] palabras_busqueda = this.txt_buscar.Text.Split(' ');

            foreach (string palabra in palabras_busqueda)
            {
                if (salida_datos.Length == 0)
                {
                    salida_datos = "(nombre LIKE '%" + palabra +
                        "%' OR apellido LIKE '%" + palabra +
                        "%' OR dni LIKE '%" + palabra + "%')";
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
                "us.id_usuario AS ID, " +
                "us.nombre AS NOMBRE, " +
                "us.apellido AS APELLIDO, " +
                "us.dni AS DNI, " +
                "us.usuario AS USUARIO, " +
                "us.[Password] AS CONTRASEÑA, " +
                "us.email AS EMAIL, " +
                "per.descripcion AS PERFIL," +
                "us.telefono AS TELÉFONO, " +
                "us.direccion AS DIRECCIÓN, " +
                "us.fecha_nac AS " +
                "'FECHA NACIMIENTO' " +
                "FROM Usuario us INNER JOIN Perfil per ON us.id_perfil = per.id_perfil", ref resultados, "Usuario");
            //probando buscador
            this.filtro = ((DataTable)resultados.Tables["Usuario"]).DefaultView;

            //igualamos el datagridview al resultado del filtro
            this.dgv_usuarios.DataSource = filtro;
        }
    }
}
