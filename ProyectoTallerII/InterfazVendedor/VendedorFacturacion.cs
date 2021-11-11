using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;
using CapaNegocio;
using CapaEntidad;

namespace ProyectoTallerII
{
    public partial class Form_facturacion_vendedor : Form
    {
        public Form_facturacion_vendedor()
        {
            InitializeComponent();
        }

        private void Form_facturacion_vendedor_Load(object sender, EventArgs e)
        {
            this.inicioVendedor();
        }

        private void inicioVendedor()
        {
            txt_fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txt_fecha.Enabled = false;
            txt_vendedor.Text = UserLognCache.nombre_usuario + " " + UserLognCache.apellido_usuario;
            txt_vendedor.Enabled = false;
            txt_dni_v.Text = UserLognCache.dni_usuario;
            txt_dni_v.Enabled = false;
            txt_tel_v.Text = UserLognCache.tel_usuario;
            txt_tel_v.Enabled = false;
        }

        private void btn_buscar_cliente_Click(object sender, EventArgs e)
        {
            using (var modal = new VendedorBuscarClientes()){
                var result = modal.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txt_dni.Text = modal.client.dni;
                    txt_nomyape.Text = modal.client.nombre + " " + modal.client.apellido;
                    txt_tel.Text = modal.client.telefono;
                    txt_correo.Text = modal.client.email;
                }
            }
        }

        private void btn_buscar_producto_Click(object sender, EventArgs e)
        {
            using (var modal = new BuscarProductos())
            {
                var result = modal.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txt_cod.Text = modal.producto.cod_producto;
                    txt_prod_nombre.Text = modal.producto.nombre;
                    txt_marca.Text = modal.producto.marca;
                    txt_material.Text = modal.producto.material;
                    txt_kilates.Text = modal.producto.kilates;
                    txt_stock.Text = modal.producto.stock.ToString();
                    txt_precio.Text = modal.producto.precio.ToString();
                }
            }
        }

        private void txt_cod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                CapaEntidad.Producto prod = new cn_productos().Listar().Where(p => p.cod_producto == txt_cod.Text && p.estado == true).FirstOrDefault();

                if (prod !=  null)
                {
                    MessageBox.Show("Producto encontrado exitosamente", "ENCONTRADO!", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);

                    txt_cod.Text = prod.cod_producto.ToString();
                    txt_prod_nombre.Text = prod.nombre.ToString();
                    txt_marca.Text = prod.marca.ToString();
                    txt_material.Text = prod.material.ToString();
                    txt_kilates.Text = prod.material.ToString();
                    txt_stock.Text = prod.stock.ToString();
                    txt_precio.Text = prod.precio_venta.ToString(); 
                }
                else
                {
                    MessageBox.Show("Producto no encontrado, intente de nuevo", "NO ENCONTRADO!", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);

                    txt_cod.Text = "";
                    txt_prod_nombre.Text = "";
                    txt_marca.Text = "";
                    txt_material.Text = "";
                    txt_kilates.Text = "";
                    txt_stock.Text = "";
                    txt_precio.Text = "";
                }
            }
        }



        private void LimpiarVenta()
        {
            txt_cod.Text = "";
            txt_prod_nombre.Text = "";
            txt_marca.Text = "";
            txt_material.Text = "";
            txt_kilates.Text = "";
            txt_stock.Text = "";
            txt_precio.Text = "";
            txt_cantidad.Text = "";
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            this.LimpiarVenta();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            decimal precio = 0;
            bool prod_existe = false;

            //eliminar.Text = "Eliminar";

            //valida codigo no nulo
            if (txt_cod.Text == "")
            {
                MessageBox.Show("El campo Codigo de producto no debe star vacío", "NO VÁLIDO!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                return;
            }

            if (txt_stock.Text == "")
            {
                MessageBox.Show("El campo Stock no debe star vacío", "NO VÁLIDO!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                return;
            }


            if (txt_cantidad.Text == "")
            {
                MessageBox.Show("La cantidad no puede estar vacía", "NO VÁLIDO!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                txt_cantidad.Select();
                return;

            }


            //validar formato rpecio
            if (!decimal.TryParse(txt_precio.Text, out precio))
            {
                MessageBox.Show("Ingrese un precio com formato válido", "NO VÁLIDO!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                return;
            }


            //validar stock
            if (Convert.ToInt32(txt_stock.Text) < Convert.ToInt32(txt_cantidad.Text.ToString()))
            {
                MessageBox.Show("La cantidad no puede ser mayor al stock", "NO VÁLIDO!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                return;
            }
            // validar cantidad vacio

            



            //validar existencia del producto en el datagrid
            foreach (DataGridViewRow fila in data_productos.Rows)
            {
                if (fila.Cells["cod_prod"].Value.ToString() == txt_cod.Text)
                {
                    prod_existe = true;
                    break;
                }
            }

            if (!prod_existe)
            {
                data_productos.Rows.Add(new object[]
                {
                    txt_cod.Text,
                    txt_prod_nombre.Text,
                    txt_marca.Text,
                    txt_material.Text,
                    txt_kilates.Text,
                    txt_stock.Text,
                    txt_precio.Text,
                    txt_cantidad.Text,
                    (Convert.ToDecimal(txt_cantidad.Text) * Convert.ToDecimal(txt_precio.Text)).ToString()
                });
                this.CalcularTotal();
            }
        }

        private void CalcularTotal()
        {
            decimal total = 0;
            if (data_productos.Rows.Count > 0)
            {
                foreach(DataGridViewRow row in data_productos.Rows)
                {
                    total += Convert.ToDecimal(row.Cells["sub_total"].Value.ToString());
                }
            }

            txt_total.Text = total.ToString();
            this.LimpiarVenta();
            txt_cod.Select();
        }


        //metodo para calcular el vuelto 
        private void CalcularVuelto()
        {
            if (txt_total.Text.Trim() == "")
            {
                MessageBox.Show("No existen productos en lista de compra", "ERROR!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                return;
            }

            decimal pagacon;
            decimal total = Convert.ToDecimal(txt_total.Text);

            if (txt_importe.Text.Trim() == "")
            {
                txt_total.Text = "0";
            }

            if (decimal.TryParse(txt_importe.Text.Trim(), out pagacon))
            {
                if(pagacon < total)
                {
                    txt_velto.Text = "0,00";
                }
                else
                {
                    decimal vuelto = pagacon - total;
                    txt_velto.Text = vuelto.ToString();
                }
            }
        }






        
        
        
        
        
        
        
        private void data_productos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (data_productos.Columns[e.ColumnIndex].Name == "eliminar")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    data_productos.Rows.RemoveAt(index);
                    this.CalcularTotal();
                }
            }
        }

        private void txt_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }


            // solo 1 punto decimal
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void bunifuTextBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }


            // solo 1 punto decimal
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_cod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void bunifuTextBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void bunifuTextBox14_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                this.CalcularVuelto();
            }
        }
    }
}
