using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    //clase que permite realizar consultas a la base de datos 
    public class cd_clientes
    {
        //se instancia una varaiable de tipo cd_conexion para  indicar los datos de la base 
        private cd_conexion connection = new cd_conexion();

        SqlDataReader leer_clientes; //variable para leer coientes
        DataTable tabla_cliente = new DataTable(); //variable para  almacenar los datos leidos
        SqlCommand comando_clientes = new SqlCommand(); //variable para almacvenar procedimientos almacenados

        //fincion que permite mostrar los clientes
        public DataTable mostrar_clientes()
        {
            //inicio TRANSACT SQL
            comando_clientes.Connection = connection.abrir_conexion(); // se abre la conexion
            comando_clientes.CommandText = "sp_mostrar_clientes"; // se genera la consulta
            comando_clientes.CommandType = CommandType.StoredProcedure;
            leer_clientes = comando_clientes.ExecuteReader(); // se lee la consulta
            tabla_cliente.Load(leer_clientes); //  se carga el resultado de la consulta en una tabla 
            connection.cerrar_conexion(); //  se cierra la conexion
            return tabla_cliente; // retorno del objeto que contiene el resultado de la consulta
        }
    }
}
