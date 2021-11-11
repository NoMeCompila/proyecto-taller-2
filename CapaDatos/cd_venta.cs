using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;
    
namespace CapaDatos
{
    public class cd_venta
    {
        
        public int GetCorrelativo()
        {
            int id_correlativo = 0;

            using (SqlConnection conexion = new SqlConnection("Server = DESKTOP-C7M4JOU; Database = JOYERIA; Integrated Security = true")) {



                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select count(*) + 1 from Ventas");
                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.CommandType = CommandType.Text;
                    conexion.Open();

                    id_correlativo = Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    id_correlativo = 0;
                }
            }

            return id_correlativo;
        }

        
        public bool RestarStock(string cod_producto, int cantidad)
        {
            bool respuesta = true;

            using (SqlConnection conexion = new SqlConnection("Server = DESKTOP-C7M4JOU; Database = JOYERIA; Integrated Security = true"))
            {
                try
                {

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update Producto set stock = stock - @cantidad where cod_producto = @cod_producto");
                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@cantidad",cantidad);
                    cmd.Parameters.AddWithValue("@cod_producto", cod_producto);

                    cmd.CommandType = CommandType.Text;
                    conexion.Open();

                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;


                }
                catch (Exception ex)
                {
                    return respuesta = false;
                }
            }
            return respuesta;
        }





        public bool SumarStock(string cod_producto, int cantidad)
        {
            bool respuesta = true;

            using (SqlConnection conexion = new SqlConnection("Server = DESKTOP-C7M4JOU; Database = JOYERIA; Integrated Security = true"))
            {
                try
                {

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update Producto set stock = stock + @cantidad where cod_producto = @cod_producto");
                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@cod_producto", cod_producto);

                    cmd.CommandType = CommandType.Text;
                    conexion.Open();

                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;


                }
                catch (Exception ex)
                {
                    return respuesta = false;
                }
            }
            return respuesta;
        }



        public bool Registrar(Ventas obj, DataTable DetalleVenta, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;
            try
            {
                using (SqlConnection conexion = new SqlConnection("Server = DESKTOP-C7M4JOU; Database = JOYERIA; Integrated Security = true"))
                {
                    SqlCommand cmd = new SqlCommand("sp_registrar_venta", conexion);
                    cmd.Parameters.AddWithValue("id_venta", obj.id_venta);
                    cmd.Parameters.AddWithValue("id_vendedor", obj.id_vendedor);

                    cmd.Parameters.AddWithValue("id_cliente", obj.id_cliente);
                    cmd.Parameters.AddWithValue("id_tpago", obj.id_tpago);
                    cmd.Parameters.AddWithValue("total", obj.total);
                    cmd.Parameters.AddWithValue("fecha", obj.fecha);

                    cmd.Parameters.AddWithValue("vendedor_dni", obj.vendedor_dni);
                    cmd.Parameters.AddWithValue("cliente_dni", obj.cliente_dni);
                    cmd.Parameters.AddWithValue("cliente_tel", obj.cliente_tel);
                    cmd.Parameters.AddWithValue("cliente_email", obj.cliente_email);
                    cmd.Parameters.AddWithValue("cliente_fullname", obj.cliente_fullname);
                    cmd.Parameters.AddWithValue("importe", obj.importe);
                    cmd.Parameters.AddWithValue("vuelto", obj.vuelto);
                    cmd.Parameters.Add("resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    conexion.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["resultado"].Value);
                    mensaje = cmd.Parameters["mensaje"].Value.ToString();
                }
            }catch(Exception ex)
            {
                respuesta = false;
                mensaje = ex.Message;
            }

            return respuesta;

        }

    }
}
