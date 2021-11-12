using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Producto
    {
        public int id_prod { get; set; }
        public string cod_producto { get; set; }
        public string nombre { get; set; }
        public string marca { get; set; }
        public string material { get; set; }
        public string kilates { get; set; }
        public int stock { get; set; }
        public decimal precio { get; set; }
    }
}
