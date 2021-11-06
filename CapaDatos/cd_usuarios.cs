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
        SqlCommand comando_usuasrios = new SqlCommand();

        public DataTable mostrar_usuarios()
        {
            comando_usuasrios.Connection = connection.abrir_conexion();
            comando_usuasrios.CommandText = "sp_listar_usuarios";
            comando_usuasrios.CommandType = CommandType.StoredProcedure;
            leer_usuasrios = comando_usuasrios.ExecuteReader();
            tabla_usuasrios.Load(leer_usuasrios);
            connection.cerrar_conexion();
            return tabla_usuasrios;
        }

        public void guardar_usuario(string nombre, string apellido, string dni, string usuario, string contraseña, string email, int id_perfil, string tel, string direccion, DateTime fecha_nac)
        {
            comando_usuasrios.Connection = connection.abrir_conexion();
            comando_usuasrios.CommandText = "sp_guardar_usuario";
            comando_usuasrios.CommandType = CommandType.StoredProcedure;
            comando_usuasrios.Parameters.AddWithValue("@nombre", nombre);
            comando_usuasrios.Parameters.AddWithValue("@apellido", apellido);
            comando_usuasrios.Parameters.AddWithValue("@dni", dni);
            comando_usuasrios.Parameters.AddWithValue("@usuario",usuario);
            comando_usuasrios.Parameters.AddWithValue("@contra", contraseña);
            comando_usuasrios.Parameters.AddWithValue("@email", email);
            comando_usuasrios.Parameters.AddWithValue("@id_perfil", id_perfil);
            comando_usuasrios.Parameters.AddWithValue("@tel", tel);
            comando_usuasrios.Parameters.AddWithValue("@direccion", direccion);
            comando_usuasrios.Parameters.AddWithValue("@fecha_nac", fecha_nac);
            comando_usuasrios.ExecuteNonQuery();
            comando_usuasrios.Parameters.Clear();
        }
    }
}
