using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class cd_productos
    {
        //se instancia una varaiable de tipo cd_conexion para  indicar los datos de la base 
        private cd_conexion connection = new cd_conexion();

        SqlDataReader leer_producto; //variable para leer productos
        DataTable tabla_producto = new DataTable(); //variable para  almacenar los datos leidos
        SqlCommand comando_producto = new SqlCommand(); //variable para almacvenar procedimientos almacenados

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
