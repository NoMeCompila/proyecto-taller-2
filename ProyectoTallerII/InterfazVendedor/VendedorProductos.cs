using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoTallerII
{
    public partial class Form_listar_productos : Form
    {
        public Form_listar_productos()
        {
            InitializeComponent();
        }

        private void Form_listar_productos_Load(object sender, EventArgs e)
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
                    salida_datos = "(tipo LIKE '%" + palabra +
                        "%' OR nombre LIKE '%" + palabra +
                        "%' OR material LIKE '%" + palabra + "%')";
                }
                else
                {
                    salida_datos += "AND (tipo LIKE '%" + palabra +
                        "%' OR nombre LIKE '%" + palabra +
                        "%' OR material LIKE '%" + palabra + "%')";
                }
            }

            this.filtro.RowFilter = salida_datos;
        }




        private void mostrar_busqueda()
        {

            //mostrar_client_admin();
            this.leer_datos("SELECT " +
                "pro.id_producto AS  ID, " +
                "cat.descripcion AS TIPO, " +
                "pro.cod_producto AS CODIGO, " +
                "pro.nombre AS NOMBRE, " +
                "pro.stock AS STOCK, " +
                "pro.precio_costo AS 'PRECIO COSTO', " +
                "pro.precio_venta AS 'PRECIO VENTA', " +
                "pro.marca AS MARCA," +
                "pro.genero AS GENERO," +
                "pro.material AS MATERIAL," +
                "pro.gema AS GEMA FROM Producto pro INNER JOIN Categoria cat  ON pro.fk_id_categoria = cat.id_categoria WHERE pro.estado = 1", ref resultados, "Producto");
            //probando buscador
            this.filtro = ((DataTable)resultados.Tables["Producto"]).DefaultView;

            //igualamos el datagridview al resultado del filtro
            this.dgv_productos.DataSource = filtro;
        }
    }
}
