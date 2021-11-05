using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class cd_perfiles
    {   
        private cd_conexion connection = new cd_conexion();
        SqlDataReader leer_perfiles; 
        DataTable tabla_perfiles = new DataTable(); 
        SqlCommand comando_perfiles= new SqlCommand();

        public DataTable mostrar_perfiles()
        {
            DataTable Tabla = new DataTable();
            comando_perfiles.Connection = connection.abrir_conexion();
            comando_perfiles.CommandText = "sp_listar_perfiles";
            comando_perfiles.CommandType = CommandType.StoredProcedure;
            leer_perfiles = comando_perfiles.ExecuteReader();
            tabla_perfiles.Load(leer_perfiles);
            connection.cerrar_conexion();
            return tabla_perfiles;
        }
    }
}
