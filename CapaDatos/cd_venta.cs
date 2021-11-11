using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
    
namespace CapaDatos
{
    public class cd_venta
    {
        //Datetable datetable = new Datetable();
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

        
        public bool RestarStock(int id_producto, int cantidad)
        {
            bool respuesta = true;

            using (SqlConnection conexion = new SqlConnection("Server = DESKTOP-C7M4JOU; Database = JOYERIA; Integrated Security = true"))
            {
                try
                {

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update Producto set stock = stock - @cantidad where id_producto = @id_produco");
                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@cantidad",cantidad);
                    cmd.Parameters.AddWithValue("@id_producto", id_producto);

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





        public bool SumarStock(int id_producto, int cantidad)
        {
            bool respuesta = true;

            using (SqlConnection conexion = new SqlConnection("Server = DESKTOP-C7M4JOU; Database = JOYERIA; Integrated Security = true"))
            {
                try
                {

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update Producto set stock = stock + @cantidad where id_producto = @id_produco");
                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@id_producto", id_producto);

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

    }
}
