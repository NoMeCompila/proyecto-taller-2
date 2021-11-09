using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    class UserNegocio
    {
        UserDatos userDat = new UserDatos();
        public bool login_user(string usuario, string contraseña)
        {
            return userDat.Login(usuario, contraseña);
        }
    }
}
