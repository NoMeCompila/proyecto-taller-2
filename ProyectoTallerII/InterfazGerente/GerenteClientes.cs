using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectoTallerII
{
    public partial class GerenteClientes : Form
    {
        public GerenteClientes()
        {
            InitializeComponent();
        }

        private void btn_user_agregar_Click(object sender, EventArgs e)
        {

        }

        private void GerenteClientes_Load(object sender, EventArgs e)
        {
            this.mostrar_busqueda();
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
                "Cliente.id_cliente as ID, " +
                "Cliente.nombre AS NOMBRE, " +
                "Cliente.apellido AS APELLIDO, " +
                "Cliente.dni AS DNI, " +
                "Cliente.email AS EMAIL, " +
                "Cliente.telefono AS TELÉFONO, " +
                "Cliente.direccion AS DIRECCIÓN, " +
                "Cliente.fecha_nac AS " +
                "'FECHA NACIMIENTO' " +
                "FROM Cliente WHERE estado = 1", ref resultados, "Cliente");
            //probando buscador
            this.filtro = ((DataTable)resultados.Tables["Cliente"]).DefaultView;

            //igualamos el datagridview al resultado del filtro
            this.dataG_usuarios.DataSource = filtro;
        }
    }
}
