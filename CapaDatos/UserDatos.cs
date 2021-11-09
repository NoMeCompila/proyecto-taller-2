using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;



namespace CapaDatos
{
    //clase que abre una conexion a abse de datos y se encarga de verificar que exista un usuario con las credenciales
    public class UserDatos: cd_conexion
    {
        public bool Login(string usuario, string contraseña)
        {
            using (var conexion = abrir_conexion())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    //se realiza la consulta y se indica el tipo de comando
                    comando.Connection = conexion;
                    comando.CommandText = "select * from Usuario where usuario = @usuario adn Password = @contraseña";
                    comando.Parameters.AddWithValue("@usuario", usuario);
                    comando.Parameters.AddWithValue("@contraseña", contraseña);
                    comando.CommandType = CommandType.Text;
                    //se declara una variable que sirve como lector de la entrada de consulta
                    SqlDataReader reader = comando.ExecuteReader();
                    //si la consulta tiene filas entonces es valida la conexion en caso contrario retorna false
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
}
