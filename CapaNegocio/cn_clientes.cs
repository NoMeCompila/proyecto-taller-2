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
    }
}
