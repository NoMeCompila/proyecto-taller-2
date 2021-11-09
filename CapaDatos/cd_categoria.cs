using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class cd_categoria
    {
        private cd_conexion connection = new cd_conexion();
        SqlDataReader leer_categorias;
        DataTable tabla_categorias = new DataTable();
        SqlCommand comando_categorias = new SqlCommand();

        public DataTable mostrar_categorias()
        {
            DataTable Tabla = new DataTable();
            comando_categorias.Connection = connection.abrir_conexion();
            comando_categorias.CommandText = "sp_mostrar_categorias";
            comando_categorias.CommandType = CommandType.StoredProcedure;
            leer_categorias = comando_categorias.ExecuteReader();
            tabla_categorias.Load(leer_categorias);
            connection.cerrar_conexion();
            return tabla_categorias;
        }

    }
}
