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



        public bool Registrar(Ventas obj, DataTable detalle_tabla, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;
            
                using (SqlConnection conexion = new SqlConnection("Server = DESKTOP-C7M4JOU; Database = JOYERIA; Integrated Security = true"))
                {
                    SqlCommand cmd = new SqlCommand("sp_registro", conexion);
                    //cmd.Parameters.AddWithValue("id_venta", obj.id_venta);
                    cmd.Parameters.AddWithValue("id_vendedor", obj.id_vendedor);

                    cmd.Parameters.AddWithValue("id_cliente", obj.id_cliente);
                    cmd.Parameters.AddWithValue("total", obj.total);
                    cmd.Parameters.AddWithValue("fecha", obj.fecha);
                    cmd.Parameters.AddWithValue("vendedor_dni", obj.vendedor_dni);

                    cmd.Parameters.AddWithValue("cliente_dni", obj.cliente_dni);
                    cmd.Parameters.AddWithValue("cliente_tel", obj.cliente_tel);
                    cmd.Parameters.AddWithValue("cliente_email", obj.cliente_email);
                    cmd.Parameters.AddWithValue("cliente_fullname", obj.cliente_fullname);
                    cmd.Parameters.AddWithValue("importe", obj.importe);
                    cmd.Parameters.AddWithValue("vuelto", obj.vuelto);
                    cmd.Parameters.AddWithValue("vendedor_nombre", obj.vendedor_nombre);
                    cmd.Parameters.AddWithValue("vendedor_tel", obj.vendedor_tel);
                    cmd.Parameters.AddWithValue("nro_correlativo", obj.nro_correlativo);

                    cmd.Parameters.AddWithValue("detalle_tabla", detalle_tabla);


                    cmd.Parameters.Add("resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    conexion.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["resultado"].Value);
                    mensaje = cmd.Parameters["mensaje"].Value.ToString();
                }
           

            return respuesta;

        }



        public Ventas GetVenta(string nro)
        {
            Ventas vta = new Ventas();
             using (SqlConnection conexion = new SqlConnection("Server = DESKTOP-C7M4JOU; Database = JOYERIA; Integrated Security = true"))
            {
                try
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select v.id_venta, v.nro_correlativo as 'nro factura',");
                    query.AppendLine("v.fecha  as fecha,");
                    query.AppendLine("u.dni as 'vendedor dni',");
                    query.AppendLine("CONCAT(u.nombre, ' ', u.apellido)  as 'vendedor nombre',");
                    query.AppendLine("c.id_cliente as 'id cliente', ");
                    query.AppendLine("c.dni as 'cliente dni',");
                    query.AppendLine("c.telefono as 'cliente tel.',");
                    query.AppendLine("CONCAT(c.nombre, ' ', c.apellido)  as 'cliente nombre',");
                    query.AppendLine("c.email as 'cliente correo',");
                    query.AppendLine("v.total as total,");
                    query.AppendLine("v.importe as importe,");
                    query.AppendLine("v.vuelto as vuelto");
                    query.AppendLine("from Ventas where v.nro_correlativo = @nro_correlativo  v inner join Usuario u on v.id_vendedor = u.id_usuario inner join Cliente c on c.id_cliente = v.id_cliente");
                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@numero", nro);
                    cmd.CommandType = System.Data.CommandType.Text;


                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while(dr.Read())
                        {
                            vta = new Ventas()
                            {
                                id_venta = int.Parse(dr["id_venta"].ToString()),
                                nro_correlativo = dr["nro factura"].ToString(),
                                fecha = Convert.ToDateTime(dr["fecha"].ToString()),
                                vendedor_dni = dr["vendedor dni"].ToString(),
                                vendedor_nombre = dr["vendedor nombre"].ToString(),
                                id_cliente = Convert.ToInt32(dr["id cliente"].ToString()),
                                cliente_dni = dr["cliente dni"].ToString(),
                                cliente_tel= dr["cliente tel."].ToString(),
                                cliente_fullname = dr["cliente tel."].ToString(),
                                cliente_email = dr["cliente correo"].ToString(),
                                total = Convert.ToInt32(dr["total"].ToString()),
                                importe = Convert.ToInt32(dr["importe"].ToString()),
                                vuelto = Convert.ToInt32(dr["vuelto"].ToString()),
                                
                                


                            };
                        }
                    }

                }
                catch(Exception ex)
                {
                    vta = new Ventas();
                }
            }

                return vta;
        }

        public List<ventas_detalle> getDetalle(int id_venta)
        {
            List<ventas_detalle> detalleLista = new List<ventas_detalle>();
            using (SqlConnection conexion = new SqlConnection("Server = DESKTOP-C7M4JOU; Database = JOYERIA; Integrated Security = true"))
            {
                try
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select  p.id_producto as 'ID producto',");
                    query.AppendLine("p.cod_producto as 'Cod producto',");
                    query.AppendLine("p.nombre as nombre,");
                    query.AppendLine("p.material as material,");
                    query.AppendLine("p.gema as kilates,");
                    query.AppendLine("p.precio_venta as precio,");
                    query.AppendLine("vd.cantidad as cantidad,");
                    query.AppendLine("vd.sub_total as subtotal");
                    query.AppendLine("from VentaDetalle vd inner join Producto p  on vd.id_producto = p.id_producto");
                    query.AppendLine("where vd.id_venta = @id_venta");


                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@id_venta", id_venta);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            detalleLista.Add(new ventas_detalle()
                            {


                                /*id_venta = int.Parse(dr["id_venta"].ToString()),
                                nro_correlativo = dr["nro factura"].ToString(),
                                fecha = Convert.ToDateTime(dr["fecha"].ToString()),
                                vendedor_dni = dr["vendedor dni"].ToString(),
                                vendedor_nombre = dr["vendedor nombre"].ToString(),
                                id_cliente = Convert.ToInt32(dr["id cliente"].ToString()),
                                cliente_dni = dr["cliente dni"].ToString(),
                                cliente_tel= dr["cliente tel."].ToString(),
                                cliente_fullname = dr["cliente tel."].ToString(),
                                cliente_email = dr["cliente correo"].ToString(),
                                total = Convert.ToInt32(dr["total"].ToString()),
                                importe = Convert.ToInt32(dr["importe"].ToString()),
                                vuelto = Convert.ToInt32(dr["vuelto"].ToString()),*/

                                id_producto = int.Parse(dr["ID producto"].ToString()),
                                cod_producto = dr["Cod producto"].ToString(),
                                nombre = dr["nro factura"].ToString(),
                                material = dr["material"].ToString(),
                                gema = dr["kilates"].ToString(),
                                precio_venta = Convert.ToDecimal(dr["precio"].ToString()),
                                cantidad = Convert.ToInt32(dr["cantidad"].ToString()),
                                sub_total = Convert.ToDecimal(dr["vuelto"].ToString()),
                            }) ;
                        }
                    }


                }
                catch
                {
                    detalleLista = new List<ventas_detalle>();
                }
            }


                return detalleLista;
        }

    }
}
