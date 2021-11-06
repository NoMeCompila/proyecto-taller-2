﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocio
{
    public class cn_usuarios
    {
        private cd_usuarios objetoCD = new cd_usuarios();

        public DataTable mostrar_usuarios()
        {
            DataTable tabla_usuarios = new DataTable();
            tabla_usuarios = objetoCD.mostrar_usuarios();
            return tabla_usuarios;
        }

        public void guardar_usuario(string nombre, string apellido, string dni,string usuario,string contraseña, 
            string email, int id_perfil, string tel,
            string direccion, string fecha_nac)
        {
            objetoCD.guardar_usuario(nombre, apellido, dni, usuario,contraseña, email, id_perfil, tel, 
                direccion, Convert.ToDateTime(fecha_nac));
        }
    }
}
