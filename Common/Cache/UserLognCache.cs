using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Cache
{
    //calse donde se guardan las credenciales de inicio de sesion de un nusuario y puede ser accedida en cuaquier momento
    //desde cualquier capa para mantener a la seguridad transeversal de la aplicación
    public class UserLognCache
    {
        //datops de un usuario accesible a todas las capas
        public static int id_usuario { get; set; }
        public static int id_perfil { get; set; }
        public static string nombre_usuario { get; set; }
        public static string apellido_usuario { get; set; }
        public static string dni_usuario { get; set; }
        public static string user { get; set; }
        public static string pass { get; set; }
        //public static string correo_user { get; set; }
        public static string tel_usuario { get; set; }

    }


}
