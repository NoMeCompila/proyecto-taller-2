using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Producto
    {
        public int ID { get; set; }
        public string cod_producto { get; set; }
        public string descripcion { get; set; }
        public string nombre { get; set; }
        public string marca { get; set; }
        public string material { get; set; }
        public string kilates { get; set; }
        public int stock { get; set; }
        public decimal precio_costo { get; set; }
        public decimal precio_venta { get; set; }
        public string genero { get; set; }

        public bool estado { get; set; }
    }
}
