using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
//using System.Windows.Forms;

using System.Runtime.InteropServices;
using Common.Cache;

namespace CapaDatos
{
    //clase que abre una conexion a abse de datos y se encarga de verificar que exista un usuario con las credenciales
    public class UserDatos: cd_conexion
    {

        //funcion para llamar a los metodos necesarios para ejecutar un login de usuario
        public bool Login(string usuario, string contraseña)
        {
            using (var conexion = abrir_conexion())
            {
                //conexion.Open();
                using (var comando = new SqlCommand())
                {
                    //se realiza la consulta y se indica el tipo de comando
                    comando.Connection = conexion;
                    comando.CommandText = "select * from Usuario where usuario = @usuario and Password = @contraseña";
                    comando.Parameters.AddWithValue("@usuario", usuario);
                    comando.Parameters.AddWithValue("@contraseña", contraseña);
                    comando.CommandType = CommandType.Text;
                    //se declara una variable que sirve como lector de la entrada de consulta
                    SqlDataReader reader = comando.ExecuteReader();
                    //si la consulta tiene filas entonces es valida la conexion en caso contrario retorna false
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserLognCache.id_usuario = reader.GetInt32(0);
                            UserLognCache.id_perfil= reader.GetInt32(1);
                            UserLognCache.nombre_usuario = reader.GetString(2);
                            UserLognCache.apellido_usuario = reader.GetString(3);
                            UserLognCache.dni_usuario = reader.GetString(4);
                            
                            UserLognCache.user = reader.GetString(5);
                            UserLognCache.pass = reader.GetString(6);
                            UserLognCache.tel_usuario = reader.GetString(8);
                        }
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
