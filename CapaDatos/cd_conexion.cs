using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    class cd_conexion
    {
        //objeto que guarda la cadena de conexion
        private SqlConnection conexion = new SqlConnection(
            "Server = DESKTOP-C7M4JOU;" + // nombre dels erver local de sql
            "Database = JOYERIA;" + // nombre de la abse de datos
            "Integrated Security = true"); // seguridad integrada de windows (sin usuario ni contraseña)

        // funcion para abrir la conexion a base  de datos local
        public SqlConnection abrir_conexion()
        {
            // si el estado de la conexion esta cerrada entonces cambia su estado a abierto
            if (conexion.State == ConnectionState.Closed) 
                conexion.Open();
            return conexion;
        }

        // funcion para cerrar la conexion a base de datos local
        public SqlConnection cerrar_conexion()
        {
            // si el estado de la conexion esta abierto entonces cambia su estado a cerrado
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
            return conexion;
        }


    }
}
