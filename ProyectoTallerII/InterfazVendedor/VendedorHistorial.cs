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
    public partial class VendedorHistorial : Form
    {
        public VendedorHistorial()
        {
            InitializeComponent();
        }

        private void Form_facturacion_vendedor_Load(object sender, EventArgs e)
        {
            this.inicioVendedor();
        }
                                                                                                                                                                
        private void inicioVendedor()
        {
            txt_fecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
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
                    txt_id_cliente.Text = modal.client.id_cliente.ToString();
                }
            }
        }

        

        
        private void LimpiarVenta()
        {
            
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            this.LimpiarVenta();
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
                    bool respuesta = new cn_venta().SumarStock(
                        data_productos.Rows[index].Cells["cod_prod"].Value.ToString(),
                        Convert.ToInt32(data_productos.Rows[index].Cells["cantidad"].Value.ToString())
                    );

                    if (respuesta)
                    {
                        data_productos.Rows.RemoveAt(index);
                        this.CalcularTotal();
                    }

                    
                }
            }
        }

        private void txt_precio_KeyPress(object sender, KeyPressEventArgs e)
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

        private void bunifuTextBox14_KeyPress(object sender, KeyPressEventArgs e)
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

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            if (txt_dni.Text == "")
            {
                MessageBox.Show("El campo DNI del cliente no debe estar vacío", "CAMPO VACÍO!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                return;
            }


            if (txt_nomyape.Text == "")
            {
                MessageBox.Show("El campo nombre del cliente no debe estar vacío", "CAMPO VACÍO!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                return;
            }

            if (txt_tel.Text == "")
            {
                MessageBox.Show("El campo teléfono del cliente no debe estar vacío", "CAMPO VACÍO!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                return;
            }

            if (txt_correo.Text == "")
            {
                MessageBox.Show("El campo correo del cliente no debe estar vacío", "CAMPO VACÍO!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                return;
            }


            if (data_productos.Rows.Count < 1)
            {
                MessageBox.Show("no hay productos en la lista de compra, por favor ingrese los datos", "LISTA DE COMPRA VACÍA",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                return;
            }
            
            DataTable venta_detalle = new DataTable();
            venta_detalle.Columns.Add("ID", typeof(int));
            venta_detalle.Columns.Add("cantidad", typeof(int));
            venta_detalle.Columns.Add("precio", typeof(decimal));
            venta_detalle.Columns.Add("sub_total", typeof(decimal));
            venta_detalle.Columns.Add("cod_prod", typeof(string));
            venta_detalle.Columns.Add("nombre", typeof(string));
            venta_detalle.Columns.Add("material", typeof(string));
            venta_detalle.Columns.Add("marca", typeof(string));
            venta_detalle.Columns.Add("Kilates", typeof(string));
            foreach(DataGridViewRow row in data_productos.Rows)
            
            {
                venta_detalle.Rows.Add(new object[]
                {
                    Convert.ToInt32(row.Cells["ID"].Value),
                    Convert.ToInt32(row.Cells["cantidad"].Value),
                    Convert.ToDecimal(row.Cells["precio"].Value),
                    Convert.ToDecimal(row.Cells["sub_total"].Value),
                    row.Cells["cod_prod"].Value.ToString(),
                    row.Cells["nombre"].Value.ToString(),
                    row.Cells["material"].Value.ToString(),
                    row.Cells["marca"].Value.ToString(),
                    row.Cells["Kilates"].Value.ToString(),                    
                });
            }
            int id_correlativo = new cn_venta().GetCorrelativo();
            string nroDoc = string.Format("{0:00000}", id_correlativo);
            this.CalcularVuelto();

            Ventas vta = new Ventas()
            {
                id_vendedor = UserLognCache.id_usuario,
                id_cliente = Convert.ToInt32(txt_id_cliente.Text),
                total = Convert.ToDecimal(txt_total.Text.ToString()),
                fecha = Convert.ToDateTime(txt_fecha.Text.ToString()),
                vendedor_dni = UserLognCache.dni_usuario.ToString(),
                cliente_dni = txt_dni.Text.ToString(),
                cliente_tel = txt_tel.Text.ToString(),
                cliente_email = txt_correo.Text.ToString(),
                cliente_fullname = txt_nomyape.Text.ToString(),
                importe = Convert.ToDecimal(txt_importe.Text),
                vuelto = Convert.ToDecimal(txt_velto.Text),
                vendedor_nombre = UserLognCache.nombre_usuario + " " + UserLognCache.apellido_usuario,
                vendedor_tel = UserLognCache.tel_usuario.ToString(),
                nro_correlativo = nroDoc,
            };
            string mensaje = string.Empty;
            bool respuesta = new cn_venta().Registrar(vta, venta_detalle, out mensaje);

            if (respuesta)
            {
                var result = MessageBox.Show("NRO DE VENTA GENERADO: \n"+ nroDoc +"\nDesea copiarlo al porta papeles?", "VENTA REGISTRADA",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information);

                if(result == DialogResult.Yes)
                {
                    Clipboard.SetText(nroDoc);
                    this.LimpiarVenta();
                    this.LimpiarCliente();
                    data_productos.Rows.Clear();
                    txt_importe.Clear();
                    txt_total.Clear();
                    txt_velto.Clear();
                }
                
            }
            else
            {
                MessageBox.Show(mensaje, "ERROR!",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);
            }
        }

        private void LimpiarCliente()
        {
            txt_id_cliente.Clear();
            txt_dni.Clear();
            txt_tel.Clear();
            txt_correo.Clear();
            txt_nomyape.Clear();
        }

        private void txt_dni_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}










