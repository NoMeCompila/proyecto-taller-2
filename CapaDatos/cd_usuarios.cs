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
    }
}
