using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
using CapaEntidad;

namespace CapaNegocio
{
    public class cn_venta
    {
        private cd_venta objeto_venta = new cd_venta();


        public bool RestarStock(string cod_producto, int cantidad)
        {
            return objeto_venta.RestarStock(cod_producto, cantidad);
        }

        public bool SumarStock(string cod_producto, int cantidad)
        {
            return objeto_venta.SumarStock(cod_producto, cantidad);
        }


        public int GetCorrelativo()
        {
            return objeto_venta.GetCorrelativo();
        }


        public bool Registrar(Ventas obj, DataTable DetalleVenta, out string mensaje)
        {
            return objeto_venta.Registrar(obj, DetalleVenta, out mensaje);
        }
    }
}
