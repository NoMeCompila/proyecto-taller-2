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
    public class cd_productos
    {
        //se instancia una varaiable de tipo cd_conexion para  indicar los datos de la base 
        private cd_conexion connection = new cd_conexion();

        SqlDataReader leer_producto; //variable para leer productos
        DataTable tabla_producto = new DataTable(); //variable para  almacenar los datos leidos
        SqlCommand comando_producto = new SqlCommand(); //variable para almacvenar procedimientos almacenados



        //metodo para listar todos los productos activos
        public List<CapaEntidad.Producto> Listar()
        {
            //se genera un objeto tipo lista que almacena objetos de tipo producto
            List<CapaEntidad.Producto> lista = new List<CapaEntidad.Producto>();


            using (SqlConnection conexion = new SqlConnection("Server = DESKTOP-C7M4JOU; Database = JOYERIA; Integrated Security = true"))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT pro.id_producto AS  ID, cat.descripcion AS TIPO, pro.cod_producto AS CODIGO, pro.nombre AS NOMBRE, pro.stock AS STOCK,  pro.precio_costo AS COMPRA, pro.precio_venta AS VENTA, pro.marca AS MARCA,  pro.genero AS GENERO,   pro.material AS MATERIAL,  pro.gema AS GEMA,  pro.estado AS ESTADO");
                    query.AppendLine("FROM Producto pro INNER JOIN Categoria cat ON pro.fk_id_categoria = cat.id_categoria");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.CommandType = CommandType.Text;

                    conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new CapaEntidad.Producto()
                            {
                                ID = Convert.ToInt32(dr["ID"].ToString()),
                                descripcion = dr["TIPO"].ToString(),
                                cod_producto = dr["CODIGO"].ToString(),
                                nombre = dr["NOMBRE"].ToString(),
                                stock = Convert.ToInt32(dr["STOCK"].ToString()),
                                precio_costo = Convert.ToDecimal(dr["COMPRA"].ToString()),
                                precio_venta = Convert.ToDecimal(dr["VENTA"].ToString()),
                                marca = dr["MARCA"].ToString(),
                                genero = dr["GENERO"].ToString(),
                                material = dr["MATERIAL"].ToString(),
                                kilates = dr["GEMA"].ToString(),
                                estado = Convert.ToBoolean(dr["ESTADO"].ToString()),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<CapaEntidad.Producto>();   
                }

            }

            return lista;
                
        }
                

        
    












    public void guardar_producto(int fk_id_categoria, int cod_producto, string nombre,
        int stock, double precio_costo, double precio_venta, string marca, string genero, string material, string gema, bool estado)
        {
            comando_producto.Connection = connection.abrir_conexion();
            comando_producto.CommandText = "sp_guardar_producto";
            comando_producto.CommandType = CommandType.StoredProcedure;
            comando_producto.Parameters.AddWithValue("@fk_id_categoria", fk_id_categoria);
            comando_producto.Parameters.AddWithValue("@cod_producto", cod_producto);
            comando_producto.Parameters.AddWithValue("@nombre", nombre);
            comando_producto.Parameters.AddWithValue("@stock", stock);
            comando_producto.Parameters.AddWithValue("@precio_costo", precio_costo);
            comando_producto.Parameters.AddWithValue("@precio_venta", precio_venta);
            comando_producto.Parameters.AddWithValue("@marca", marca);
            comando_producto.Parameters.AddWithValue("@genero", genero);
            comando_producto.Parameters.AddWithValue("@material", material);
            comando_producto.Parameters.AddWithValue("@gema", gema);
            comando_producto.Parameters.AddWithValue("@estado", estado);

            comando_producto.ExecuteNonQuery();
            comando_producto.Parameters.Clear();
        }

        public void actualizar_producto(int fk_id_categoria, int cod_producto, string nombre,
        int stock, double precio_costo, double precio_venta, string marca, string genero, string material, 
        string gema, bool estado, int id_producto)
        {
            comando_producto.Connection = connection.abrir_conexion(); // se abre la conexion
            comando_producto.CommandText = "sp_actualizar_producto"; // se ejecuta el procedimiento almacenado para actualizar
            comando_producto.CommandType = CommandType.StoredProcedure; // se especifica que se espera un tipo de dato procedimiento almacenado (SP)
            comando_producto.Parameters.AddWithValue("@fk_id_categoria", fk_id_categoria);
            comando_producto.Parameters.AddWithValue("@cod_producto", cod_producto);
            comando_producto.Parameters.AddWithValue("@nombre", nombre);
            comando_producto.Parameters.AddWithValue("@stock", stock);
            comando_producto.Parameters.AddWithValue("@precio_costo", precio_costo);
            comando_producto.Parameters.AddWithValue("@precio_venta", precio_venta);
            comando_producto.Parameters.AddWithValue("@marca", marca);
            comando_producto.Parameters.AddWithValue("@genero", genero);
            comando_producto.Parameters.AddWithValue("@material", material);
            comando_producto.Parameters.AddWithValue("@gema", gema);
            comando_producto.Parameters.AddWithValue("@estado", estado);
            comando_producto.Parameters.AddWithValue("@id_producto", id_producto);
            comando_producto.ExecuteNonQuery(); // se ejecuta la consulta
            comando_producto.Parameters.Clear(); //IMPORTANTE limpiar parametros cada vez que se hace una consulta
        }

        public void eliminar_producto(int id_producto)
        {
            comando_producto.Connection = connection.abrir_conexion();
            comando_producto.CommandText = "sp_eliminar_producto";
            comando_producto.CommandType = CommandType.StoredProcedure;
            comando_producto.Parameters.AddWithValue("@id_producto", id_producto);
            comando_producto.ExecuteNonQuery(); // se ejecuta la consulta
            comando_producto.Parameters.Clear(); //limpiar los aprametros de sql command
        }


    }



}
