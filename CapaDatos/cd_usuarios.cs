using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class cd_usuarios
    {
        private cd_conexion connection = new cd_conexion();

        SqlDataReader leer_usuasrios;
        DataTable tabla_usuasrios = new DataTable();
        SqlCommand comando_usuarios = new SqlCommand();

        public DataTable mostrar_usuarios()
        {
            comando_usuarios.Connection = connection.abrir_conexion();
            comando_usuarios.CommandText = "sp_listar_usuarios";
            comando_usuarios.CommandType = CommandType.StoredProcedure;
            leer_usuasrios = comando_usuarios.ExecuteReader();
            tabla_usuasrios.Load(leer_usuasrios);
            connection.cerrar_conexion();
            return tabla_usuasrios;
        }

        public void guardar_usuario(string nombre, string apellido, string dni, string usuario, string contraseña, string email, int id_perfil, string tel, string direccion, DateTime fecha_nac)
        {
            comando_usuarios.Connection = connection.abrir_conexion();
            comando_usuarios.CommandText = "sp_guardar_usuario";
            comando_usuarios.CommandType = CommandType.StoredProcedure;
            comando_usuarios.Parameters.AddWithValue("@nombre", nombre);
            comando_usuarios.Parameters.AddWithValue("@apellido", apellido);
            comando_usuarios.Parameters.AddWithValue("@dni", dni);
            comando_usuarios.Parameters.AddWithValue("@usuario",usuario);
            comando_usuarios.Parameters.AddWithValue("@contra", contraseña);
            comando_usuarios.Parameters.AddWithValue("@email", email);
            comando_usuarios.Parameters.AddWithValue("@id_perfil", id_perfil);
            comando_usuarios.Parameters.AddWithValue("@tel", tel);
            comando_usuarios.Parameters.AddWithValue("@direccion", direccion);
            comando_usuarios.Parameters.AddWithValue("@fecha_nac", fecha_nac);
            comando_usuarios.ExecuteNonQuery();
            comando_usuarios.Parameters.Clear();
        }

        //funcion para ACTUALIZAR un nuevo usuario
        public void actualizar_usuario(string nombre, string apellido, string dni, string usuario, 
            string contraseña,  string email, int id_perfil,string tel, string direccion, 
            DateTime fecha_nac, int id_usuario)
        {
            comando_usuarios.Connection = connection.abrir_conexion(); // se abre la conexion
            comando_usuarios.CommandText = "sp_actualizar_usuario"; // se ejecuta el procedimiento almacenado para actualizar
            comando_usuarios.CommandType = CommandType.StoredProcedure; // se especifica que se espera un tipo de dato procedimiento almacenado (SP)
            comando_usuarios.Parameters.AddWithValue("@nombre", nombre);
            comando_usuarios.Parameters.AddWithValue("@apellido", apellido);
            comando_usuarios.Parameters.AddWithValue("@dni", dni);
            comando_usuarios.Parameters.AddWithValue("@usuario", usuario);
            comando_usuarios.Parameters.AddWithValue("@contra", contraseña);
            comando_usuarios.Parameters.AddWithValue("@email", email);
            comando_usuarios.Parameters.AddWithValue("@id_perfil", id_perfil);
            comando_usuarios.Parameters.AddWithValue("@tel", tel);
            comando_usuarios.Parameters.AddWithValue("@direccion", direccion);
            comando_usuarios.Parameters.AddWithValue("@fecha_nac", fecha_nac);
            comando_usuarios.Parameters.AddWithValue("@id_usuario", id_usuario);
            comando_usuarios.ExecuteNonQuery(); // se ejecuta la consulta
            comando_usuarios.Parameters.Clear(); //IMPORTANTE limpiar parametros cada vez que se hace una consulta
        }

        //fincion para eliminar físicamente a un usuario desde un perfil administrador
        public void eliminar_usuario(int id_usuario)
        {
            comando_usuarios.Connection = connection.abrir_conexion();
            comando_usuarios.CommandText = "sp_eliminar_usuario";
            comando_usuarios.CommandType = CommandType.StoredProcedure;
            comando_usuarios.Parameters.AddWithValue("@id_usuario", id_usuario);
            comando_usuarios.ExecuteNonQuery(); // se ejecuta la consulta
            comando_usuarios.Parameters.Clear(); //limpiar los aprametros de sql command
        }
    }
}
