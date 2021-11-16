using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ventas_detalle
    {
        public int id_producto { get; set; }
        public string cod_producto { get; set; }
        public string nombre { get; set; }

        public string marca { get; set; }
        public string material { get; set; }
        public string gema { get; set; }


        public decimal precio_venta { get; set; }
        public int cantidad { get; set; }
        public decimal sub_total { get; set; }





    }
}
