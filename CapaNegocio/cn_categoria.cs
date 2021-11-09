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
    public class cn_categoria
    {
        private cd_categoria objetoCD = new cd_categoria();

        public DataTable mostrar_categorias()
        {
            DataTable tabla_categorias= new DataTable();
            tabla_categorias = objetoCD.mostrar_categorias(); // variable donde se guarda el resultado de la consulta 
            return tabla_categorias;
        }
    }
}
