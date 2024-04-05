using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.BSS
{
    public class LoginBss
    {
        private LoginDal dal = new LoginDal();

        public bool IniciarSesion(string nombreUser, string contraseña)
        {
            return dal.ValidarCredenciales(nombreUser, contraseña);
        }

        public int ObtenerRolUsuario(string nombreUser)
        {
            return dal.ObtenerIdRol(nombreUser);
        }
    }
}
