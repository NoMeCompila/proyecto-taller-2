using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using CapaNegocio;

namespace ProyectoTallerII
{
    public partial class txt_marca : Form
    {
        cn_productos objetoCN = new cn_productos();
        private string id = null;
        int fila;
        public txt_marca()
        {
            InitializeComponent();
            limpiar();
        }
        void limpiar()
        {
            btn_stock_modificar.Enabled = false;
            btn_elimiar.Enabled = false;

            txt_producto_cod.Clear();
            txt_producto_nombre.Clear();
            txt_stock.Clear();
            txt_producto_costo.Clear();
            txt_producto_venta.Clear();
            txt_marca1.Clear();
            dd_genero.SelectedIndex = 0;
            txt_material.Clear();
            dd_gema.SelectedItem = 0;



            //drd_productos_categoria.SelectedIndex = 1;
            
            
            btn_stock_agregar.Enabled = true;
        }




        private void txt_producto_cod_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_producto_cod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_producto_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_producto_costo_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }


            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }



        private void txt_producto_venta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }


            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btn_producto_imagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = "C:\\Users\\%USERNAME%\\Desktop\\taller copia\\proyecto-taller-2\\ProyectoTallerII\\bin\\Debug\\Fotos";
            getImage.Filter = "Archivos de imagen: (*.jpg)(*.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png";

            if (getImage.ShowDialog() == DialogResult.OK)
            {
                //pb_producto_imagen.ImageLocation = getImage.FileName;
                //txt_ruta.Text = getImage.FileName;
            }
            else
            {
                MessageBox.Show("No se selecciono ninguna imagen", "Sin seleccion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btn_stock_limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btn_stock_agregar_Click(object sender, EventArgs e)
        {
            //string locacion_imagen = pb_producto_imagen.ImageLocation;
            //string locacion_imagen = pb_producto_imagen.ImageLocation;
            if (txt_producto_cod.Text == "" ||
                txt_producto_nombre.Text == ""
                || txt_producto_costo.Text == "" ||
                txt_producto_venta.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos!", "ERROR!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                );
            }
            else
            {
                if (MessageBox.Show("Seguro que desea guardar?",
                              "Guardar Datos!",
                              MessageBoxButtons.YesNo,
                              MessageBoxIcon.Question,
                              MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    /*
                    int writeRow = dtg_stock.Rows.Count;
                    dtg_stock.Rows.Add(1);

                    dtg_stock.Rows[writeRow].Cells[0].Value = txt_producto_cod.Text;
                    dtg_stock.Rows[writeRow].Cells[1].Value = txt_producto_nombre.Text;
                    dtg_stock.Rows[writeRow].Cells[2].Value = txt_stock.Text;
                    dtg_stock.Rows[writeRow].Cells[3].Value = txt_producto_costo.Text;
                    dtg_stock.Rows[writeRow].Cells[4].Value = txt_producto_venta.Text;
                    dtg_stock.Rows[writeRow].Cells[5].Value = drd_productos_categoria.Text;
                    dtg_stock.Rows[writeRow].Cells[6].Value = pb_producto_imagen.Image;
                    */


                    objetoCN.insertar_producto(

                                             Convert.ToInt32(drd_productos_categoria.SelectedValue),
                                             Convert.ToInt32(txt_producto_cod.Text),
                                             txt_producto_nombre.Text,
                                             Convert.ToInt32(txt_stock.Text),
                                             Convert.ToDouble(txt_producto_costo.Text),
                                             Convert.ToDouble(txt_producto_venta.Text),
                                             txt_marca1.Text,
                                             dd_genero.Text,
                                             txt_material.Text,
                                             dd_gema.Text,
                                             Convert.ToBoolean(combo_estado.Text));

                    this.mostrar_busqueda();
                    this.limpiar();
                }
            }
        }

        private void dtg_stock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;//MUY IMPORTANTE
            //Eliminar.Text = "Eliminar";

            try
            {
                //int posicion = dtg_stock.CurrentRow.Index;

                if (true)
                {
                    if (MessageBox.Show("¿Seguro que quiere eliminar?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //dtg_stock.Rows.RemoveAt(posicion);
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

        private void dtg_stock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            try
            {
                /*
                fila = dtg_stock.CurrentRow.Index;

                txt_producto_cod.Text = dtg_stock.CurrentRow.Cells[0].Value.ToString();
                txt_producto_nombre.Text = dtg_stock.CurrentRow.Cells[1].Value.ToString();
                txt_stock.Text = dtg_stock.CurrentRow.Cells[2].Value.ToString();
                txt_producto_costo.Text = dtg_stock.CurrentRow.Cells[3].Value.ToString();
                txt_producto_venta.Text = dtg_stock.CurrentRow.Cells[4].Value.ToString();
                drd_productos_categoria.Text = dtg_stock.CurrentRow.Cells[5].Value.ToString();

                MemoryStream ms = new MemoryStream();
                Bitmap img = (Bitmap)dtg_stock.CurrentRow.Cells[6].Value;
                img.Save(ms, ImageFormat.Jpeg);
                pb_producto_imagen.Image = Image.FromStream(ms);
                */
                txt_producto_cod.Text = dtg_stock.CurrentRow.Cells["codigo"].Value.ToString();
                txt_producto_nombre.Text = dtg_stock.CurrentRow.Cells["nombre"].Value.ToString();
                txt_stock.Text = dtg_stock.CurrentRow.Cells["stock"].Value.ToString();
                drd_productos_categoria.Text = dtg_stock.CurrentRow.Cells["tipo"].Value.ToString();
                txt_producto_costo.Text = dtg_stock.CurrentRow.Cells["precio costo"].Value.ToString();
                txt_producto_venta.Text = dtg_stock.CurrentRow.Cells["precio venta"].Value.ToString();
                txt_marca1.Text = dtg_stock.CurrentRow.Cells["marca"].Value.ToString();
                dd_genero.Text = dtg_stock.CurrentRow.Cells["genero"].Value.ToString();
                txt_material.Text = dtg_stock.CurrentRow.Cells["material"].Value.ToString();
                dd_gema.Text = dtg_stock.CurrentRow.Cells["gema"].Value.ToString();
                combo_estado.Text = dtg_stock.CurrentRow.Cells["estado"].Value.ToString();
                id = dtg_stock.CurrentRow.Cells["id"].Value.ToString();



                btn_elimiar.Enabled = true;
                btn_stock_agregar.Enabled = false;
                btn_stock_modificar.Enabled = true;


            }
            catch (NullReferenceException)
            {
                MessageBox.Show("La tabla está vacía, inserte datos primero", "ERROR!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                );
            }
        }

        private void btn_stock_modificar_Click(object sender, EventArgs e)
        {
            if (txt_producto_cod.Text       == "" ||
                txt_producto_nombre.Text    == ""
                || txt_producto_costo.Text  == "" ||
                txt_producto_venta.Text     == ""  )
            {
                MessageBox.Show("Debe completar todos los campos!", "ERROR!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                );
            }
            else
            {
                //bjetoCD.actualizar_producto(fk_id_categoria, cod_producto, nombre, stock,
                //precio_costo, precio_venta, marca, genero, material, gema, estado, id_producto);
                
                
                
                objetoCN.actualizar_producto(
                    Convert.ToInt32(drd_productos_categoria.SelectedValue),
                    Convert.ToInt32(txt_producto_cod.Text),
                    txt_producto_nombre.Text,
                    Convert.ToInt32(txt_stock.Text),
                    Convert.ToDouble(txt_producto_costo.Text),
                    Convert.ToDouble(txt_producto_venta.Text),
                    txt_marca1.Text,
                    dd_genero.Text,
                    txt_material.Text,
                    dd_gema.Text,
                    Convert.ToBoolean(combo_estado.Text),
                    Convert.ToInt32(id));

                mostrar_busqueda();
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

        private void txt_buscar_KeyUp(object sender, KeyEventArgs e)
        {
            string salida_datos = "";
            string[] palabras_busqueda = this.txt_buscar.Text.Split(' ');

            foreach (string palabra in palabras_busqueda)
            {
                if (salida_datos.Length == 0)
                {
                    salida_datos = "(tipo LIKE '%" + palabra +
                        "%' OR codigo LIKE '%" + palabra +
                        "%' OR material LIKE '%" + palabra + "%')";
                }
                else
                {
                    salida_datos += "AND (tipo LIKE '%" + palabra +
                        "%' OR codigo LIKE '%" + palabra +
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
                "pro.gema AS GEMA, pro.estado AS ESTADO FROM Producto pro INNER JOIN Categoria cat  ON pro.fk_id_categoria = cat.id_categoria", ref resultados, "Producto");
            //probando buscador
            this.filtro = ((DataTable)resultados.Tables["Producto"]).DefaultView;

            //igualamos el datagridview al resultado del filtro
            this.dtg_stock.DataSource = filtro;
        }

        private void listar_categrias()
        {
            cn_categoria objPer = new cn_categoria();
            drd_productos_categoria.DataSource = objPer.mostrar_categorias();
            drd_productos_categoria.DisplayMember = "descripcion";
            drd_productos_categoria.ValueMember = "id_categoria";
        }


        private void Form_stock_Load(object sender, EventArgs e)
        {
            mostrar_busqueda();
            listar_categrias();
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_elimiar_Click(object sender, EventArgs e)
        {
            id = dtg_stock.CurrentRow.Cells["id"].Value.ToString(); //IMPORTATNE: darle valor al id para especificar que dato se quiere actualizar
            if (MessageBox.Show("Seguro que desea eliminar el producto?",
                             "ELIMINAR!",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question,
                             MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                objetoCN.eliminar_producto(Convert.ToInt32(id));
                MessageBox.Show("Producto Eliminado correctamente", "ELIMINADO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.mostrar_busqueda();
                this.limpiar();
            }
            else
            {
                MessageBox.Show("Eliminacion Cancelada!", "Cancelado!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.limpiar();
            }
        }
    }
}
