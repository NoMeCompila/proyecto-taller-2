using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class UserNegocio
    {
        // se instancia un opbjeto de tipo UserDatos creado anteriormente
        UserDatos userDat = new UserDatos();

        //se crea una método booleano donde se le pasan las credenciales de un usuario para ver que devuielve la consulta
        public bool login_user(string usuario, string contraseña)
        {
            return userDat.Login(usuario, contraseña);
        }
    }
}
