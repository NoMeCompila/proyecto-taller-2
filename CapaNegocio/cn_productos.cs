using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class cn_productos
    {



        private cd_productos objetoCD = new cd_productos();

        //funcion para listar todos los productos
        public List<CapaEntidad.Producto> Listar()
        {   
            return objetoCD.Listar();
        }


        public void insertar_producto(int fk_id_categoria, int cod_producto, string nombre, int stock,
            double precio_costo, double precio_venta, string marca, string genero, string material, string gema,bool estado)
        {
            objetoCD.guardar_producto(fk_id_categoria, cod_producto, nombre, stock, 
                precio_costo, precio_venta, marca, genero, material, gema, estado);
        }


        public void actualizar_producto(int fk_id_categoria, int cod_producto, string nombre, int stock,
            double precio_costo, double precio_venta, string marca, string genero, string material, 
            string gema, bool estado, int id_producto) // valor extra para saber a que usuario se quiere actualizar
        {
            objetoCD.actualizar_producto(fk_id_categoria, cod_producto, nombre, stock,
                precio_costo, precio_venta, marca, genero, material, gema, estado, id_producto);
        }

        public void eliminar_producto(int id_producto) // valor extra para saber a que usuario se quiere actualizar
        {
            objetoCD.eliminar_producto(id_producto);
        }

    }
}
