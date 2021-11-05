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
    public class cn_perfiles
    {
        //instancia de un objeto cd_usuarios creado previamente 
        private cd_perfiles objetoCD = new cd_perfiles();

        public DataTable mostrar_perfiles()
        {
            DataTable tabla_perfiles = new DataTable();
            tabla_perfiles = objetoCD.mostrar_perfiles(); // variable donde se guarda el resultado de la consulta 
            return tabla_perfiles;
        }
    }
}
