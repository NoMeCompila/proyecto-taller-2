using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Ventas
    {
        public int id_venta { get; set; }
        public int id_vendedor { get; set; }
        public int id_cliente { get; set; }

        public decimal total { get; set; }
        public DateTime fecha { get; set; }
        public string vendedor_dni { get; set; }
        public string cliente_dni { get; set; }

        public string cliente_tel { get; set; }
        public string cliente_email { get; set; }

        public string cliente_fullname { get; set; }
        public decimal importe { get; set; }
        public decimal vuelto { get; set; }

        public string vendedor_nombre { get; set; }
        public string vendedor_tel { get; set; }
        public string nro_correlativo { get; set; }

        public List<ventas_detalle> ventas_Detalles { get; set; }
    }
}
