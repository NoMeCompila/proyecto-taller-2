using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocio
{
    public class cn_clientes
    {
        //instancia de un objeto cd_clientes creado previamente 
        private cd_clientes objetoCD = new cd_clientes();


        //*************************|-----------------------------------------------|*************************
        //*************************|--FUNCIONES PARA MAENJAR EL CRUD  DE CLIENTES--|*************************
        //*************************|-----------------------------------------------|*************************

        //funcion para MOSTRAR los datos de los clientes
        public DataTable mostrar_clientes()
        {
            DataTable tabla_clientes = new DataTable();
            tabla_clientes = objetoCD.mostrar_clientes(); // variable donde se guarda el resultado de la consulta 
            return tabla_clientes;
        }

        //funcion para INSERTAR un nuevo cliente
        public void insertar_cliete(string nombre,
                                    string apellido,
                                    string dni,
                                    string email,
                                    string tel,
                                    string direccion,
                                    string fecha_nac)
        {
            objetoCD.insertar_cliente(nombre, 
                                      apellido, 
                                      dni, 
                                      email, 
                                      tel, 
                                      direccion, 
                                      Convert.ToDateTime(fecha_nac));
        }


        //funcion para ACTUALIZAR  un cliente
        public void actualizar_cliet(string nombre,
                                    string apellido,
                                    string dni,
                                    string email,
                                    string tel,
                                    string direccion,
                                    string fecha_nac,
                                    int id_cliente) // valor extra para saber a que cliente se quiere actualizar
        {
            objetoCD.actualizar_cliente(nombre, apellido, dni, email, tel, direccion, Convert.ToDateTime(fecha_nac), Convert.ToInt32(id_cliente));
        }

        public void eliminar_client(string id_cliente)
        {
            objetoCD.eliminar_cliente(Convert.ToInt32(id_cliente));
        }
    }
}
