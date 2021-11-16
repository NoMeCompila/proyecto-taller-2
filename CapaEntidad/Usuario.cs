using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    class Usuario
    {
        public int id_usuario { get; set; }
        public int id_perfil { get; set; }
        public string  nombre  { get; set; }
        public string apellido { get; set; }
        public string dni { get; set; }
        public string usuario { get; set; }
        public string contra { get; set; }
        public string email { get; set; }
        public string tel { get; set; }
        public string direccion { get; set; }
        public DateTime fecha_nac { get; set; }
        public bool estado { get; set; }
    }
}
