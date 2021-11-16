using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;


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
            comando_clientes.CommandText = "sp_mostrar_clientes_activos"; // se genera la consulta
            comando_clientes.CommandType = CommandType.StoredProcedure;
            leer_clientes = comando_clientes.ExecuteReader(); // se lee la consulta
            tabla_cliente.Load(leer_clientes); //  se carga el resultado de la consulta en una tabla 
            connection.cerrar_conexion(); //  se cierra la conexion
            return tabla_cliente; // retorno del objeto que contiene el resultado de la consulta
        }

        //funciopn para mostrar a todos los clientes (activos e inactivos) al administrador
        public DataTable mostrar_clientes_admin()
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

        //funcion para agregrar un nuevo cliente
        public void insertar_cliente(string nombre, string apellido, string dni, string email, string tel, string direccion, DateTime fecha_nac)
        {
            comando_clientes.Connection = connection.abrir_conexion(); // se abre la conexion
            comando_clientes.CommandText = "sp_guardar_cliente"; // se ejecuta el procedimiento almacenado para insertar
            comando_clientes.CommandType = CommandType.StoredProcedure; // se especifica que se espera un tipo de dato SP
            comando_clientes.Parameters.AddWithValue("@nombre", nombre);
            comando_clientes.Parameters.AddWithValue("@apellido", apellido);
            comando_clientes.Parameters.AddWithValue("@dni", dni);
            comando_clientes.Parameters.AddWithValue("@email", email);
            comando_clientes.Parameters.AddWithValue("@tel", tel);
            comando_clientes.Parameters.AddWithValue("@direccion", direccion);
            comando_clientes.Parameters.AddWithValue("@fecha_nac", fecha_nac);
            comando_clientes.ExecuteNonQuery(); // se ejecuta la consulta
            comando_clientes.Parameters.Clear(); //IMPORTANTE limpiar parametros cada vez que se hace una consulta
        }

        public void guardar_cliente(string nombre, string apellido, string dni, 
            string email, string tel, string direccion, DateTime fecha_nac, bool estado)
        {
            comando_clientes.Connection = connection.abrir_conexion(); // se abre la conexion
            comando_clientes.CommandText = "sp_guardar_cliente_admin"; // se ejecuta el procedimiento almacenado para insertar
            comando_clientes.CommandType = CommandType.StoredProcedure; // se especifica que se espera un tipo de dato SP
            comando_clientes.Parameters.AddWithValue("@nombre", nombre);
            comando_clientes.Parameters.AddWithValue("@apellido", apellido);
            comando_clientes.Parameters.AddWithValue("@dni", dni);
            comando_clientes.Parameters.AddWithValue("@email", email);
            comando_clientes.Parameters.AddWithValue("@tel", tel);
            comando_clientes.Parameters.AddWithValue("@direccion", direccion);
            comando_clientes.Parameters.AddWithValue("@fecha_nac", fecha_nac);
            comando_clientes.Parameters.AddWithValue("@estado", estado);
            comando_clientes.ExecuteNonQuery(); // se ejecuta la consulta
            comando_clientes.Parameters.Clear(); //IMPORTANTE limpiar parametros cada vez que se hace una consulta
        }




        //funcion para ACTUALIZAR un nuevo cliente
        public void actualizar_cliente(string nombre, string apellido, string dni, string email, string tel, string direccion, DateTime fecha_nac, int id_cliente)
        {
            comando_clientes.Connection = connection.abrir_conexion(); // se abre la conexion
            comando_clientes.CommandText = "sp_actualizar_cliente"; // se ejecuta el procedimiento almacenado para insertar
            comando_clientes.CommandType = CommandType.StoredProcedure; // se especifica que se espera un tipo de dato SP
            comando_clientes.Parameters.AddWithValue("@nombre", nombre);
            comando_clientes.Parameters.AddWithValue("@apellido", apellido);
            comando_clientes.Parameters.AddWithValue("@dni", dni);
            comando_clientes.Parameters.AddWithValue("@email", email);
            comando_clientes.Parameters.AddWithValue("@tel", tel);
            comando_clientes.Parameters.AddWithValue("@direccion", direccion);
            comando_clientes.Parameters.AddWithValue("@fecha_nac", fecha_nac);
            comando_clientes.Parameters.AddWithValue("@id_cliente", id_cliente);
            comando_clientes.ExecuteNonQuery(); // se ejecuta la consulta
            comando_clientes.Parameters.Clear(); //IMPORTANTE limpiar parametros cada vez que se hace una consulta
        }

        








        public void actualizar_cliente_admin(string nombre, string apellido, string dni, 
            string email, string tel, string direccion, DateTime fecha_nac,bool estado, int id_cliente)
        {
            try { 
                comando_clientes.Connection = connection.abrir_conexion(); // se abre la conexion
                comando_clientes.CommandText = "sp_actualizar_cliente_admin"; // se ejecuta el procedimiento almacenado para insertar
                comando_clientes.CommandType = CommandType.StoredProcedure; // se especifica que se espera un tipo de dato SP
                comando_clientes.Parameters.AddWithValue("@nombre", nombre);
                comando_clientes.Parameters.AddWithValue("@apellido", apellido);
                comando_clientes.Parameters.AddWithValue("@dni", dni);
                comando_clientes.Parameters.AddWithValue("@email", email);
                comando_clientes.Parameters.AddWithValue("@tel", tel);
                comando_clientes.Parameters.AddWithValue("@direccion", direccion);
                comando_clientes.Parameters.AddWithValue("@fecha_nac", fecha_nac);
                comando_clientes.Parameters.AddWithValue("@estado", estado);
                comando_clientes.Parameters.AddWithValue("@id_cliente", id_cliente);
                comando_clientes.ExecuteNonQuery(); // se ejecuta la consulta
                comando_clientes.Parameters.Clear(); //IMPORTANTE limpiar parametros cada vez que se hace una consulta
            }
            catch (Exception ex)
            {
                comando_clientes.Parameters.Clear();
            }
        }



        //fincion para eliminar lógicamente a un usuario desde un perfil vendedor
        public void eliminar_cliente(int id_cliente)
        {
            comando_clientes.Connection = connection.abrir_conexion();
            //comando_clientes.CommandText = "sp_eliminar_cliente"; 
            comando_clientes.CommandText = "sp_cliente_inactivo";
            comando_clientes.CommandType = CommandType.StoredProcedure;
            comando_clientes.Parameters.AddWithValue("@id_cliente", id_cliente);
            comando_clientes.ExecuteNonQuery(); // se ejecuta la consulta
            comando_clientes.Parameters.Clear(); //limpiar los aprametros de sql command
        }

        //fincion para eliminar físicamente a un usuario desde un perfil administrador
        public void eliminar_cliente_admin(int id_cliente)
        {
            comando_clientes.Connection = connection.abrir_conexion();
            //comando_clientes.CommandText = "sp_eliminar_cliente"; 
            comando_clientes.CommandText = "sp_eliminar_cliente";
            comando_clientes.CommandType = CommandType.StoredProcedure;
            comando_clientes.Parameters.AddWithValue("@id_cliente", id_cliente);
            comando_clientes.ExecuteNonQuery(); // se ejecuta la consulta
            comando_clientes.Parameters.Clear(); //limpiar los aprametros de sql command
        }















        //agregar cliente 2.0
        public int registrar_cliente(Cliente cli, out string mensaje)
        {
            int id_nuevo_cliente = 0;
            mensaje = string.Empty;
            try
            {
                using (SqlConnection conexion = new SqlConnection("Server = DESKTOP-C7M4JOU; " +
                  "Database = JOYERIA; Integrated Security = true"))
                {
                    SqlCommand cmd = new SqlCommand("sp_registrar_cliente", conexion);
                    cmd.Parameters.AddWithValue("nombre", cli.nombre);

                    cmd.Parameters.AddWithValue("apellido", cli.apellido);
                    cmd.Parameters.AddWithValue("dni", cli.dni);
                    cmd.Parameters.AddWithValue("email", cli.email);
                    cmd.Parameters.AddWithValue("tel", cli.telefono);
                    cmd.Parameters.AddWithValue("direccion", cli.direccion);
                    cmd.Parameters.AddWithValue("fecha_nac", cli.fecha_nac);
                    cmd.Parameters.AddWithValue("estado", cli.estado);
                    cmd.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    

                    id_nuevo_cliente = Convert.ToInt32(cmd.Parameters["resultado"].Value);
                    mensaje = cmd.Parameters["mensaje"].Value.ToString();

                    comando_clientes.Parameters.Clear();
                }
            }
            catch (Exception ex)
            {
                id_nuevo_cliente = 0;
                mensaje = ex.Message;


            }
            return id_nuevo_cliente;
        }


        //actualziar cliente 2.0
        public bool update_cliente(Cliente cli, out string mensaje)
        {
            bool respeusta = false;
            mensaje = string.Empty;
            try
            {
                using (SqlConnection conexion = new SqlConnection("Server = DESKTOP-C7M4JOU; " +
                  "Database = JOYERIA; Integrated Security = true"))
                {
                    SqlCommand cmd = new SqlCommand("sp_update_cliente", conexion);
                    cmd.Parameters.AddWithValue("id_cliente", cli.id_cliente);
                    cmd.Parameters.AddWithValue("nombre", cli.nombre);
                    cmd.Parameters.AddWithValue("apellido", cli.apellido);
                    cmd.Parameters.AddWithValue("dni", cli.dni);
                    cmd.Parameters.AddWithValue("email", cli.email);
                    cmd.Parameters.AddWithValue("tel", cli.telefono);
                    cmd.Parameters.AddWithValue("direccion", cli.direccion);
                    cmd.Parameters.AddWithValue("fecha_nac", cli.fecha_nac);
                    cmd.Parameters.AddWithValue("estado", cli.estado);
                    cmd.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;
                    conexion.Open();
                    cmd.ExecuteNonQuery();

                    respeusta = Convert.ToBoolean(cmd.Parameters["resultado"].Value);
                    mensaje = cmd.Parameters["mensaje"].Value.ToString();
                    comando_clientes.Parameters.Clear();
                }
            }
            catch (Exception ex)
            {
                respeusta = false;
                mensaje = ex.Message;
            }
            return respeusta;
        }

        //eoliminar cliente 2.0
        public bool delete_cliente(Cliente cli, out string mensaje)
        {
            bool respeusta = false;
            mensaje = string.Empty;
            try
            {
                using (SqlConnection conexion = new SqlConnection("Server = DESKTOP-C7M4JOU; " +
                  "Database = JOYERIA; Integrated Security = true"))
                {
                    SqlCommand cmd = new SqlCommand("sp_delete_cliente", conexion);
                    cmd.Parameters.AddWithValue("id_cliente", cli.id_cliente);
                    cmd.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;
                    conexion.Open();
                    cmd.ExecuteNonQuery();

                    respeusta = Convert.ToBoolean(cmd.Parameters["resultado"].Value);
                    mensaje = cmd.Parameters["mensaje"].Value.ToString();

                    cmd.Parameters.Clear();
                }
            }
            catch (Exception ex)
            {
                respeusta = false;
                mensaje = ex.Message;
            }
            return respeusta;
        }


    }
}
