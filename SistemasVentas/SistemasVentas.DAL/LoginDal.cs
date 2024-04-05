using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class LoginDal
    {
        public bool ValidarCredenciales(string nombreUser, string contraseña)
        {
            string consulta = "SELECT COUNT(*) FROM Usuario WHERE NombreUser = @NombreUser AND Contraseña = @Contraseña";
            SqlParameter[] parametros = {
                new SqlParameter("@NombreUser", nombreUser),
                new SqlParameter("@Contraseña", contraseña)
            };
            int count = (int)Conexion.EjecutarEscalar2(consulta,parametros);
            return count > 0;
        }

        public int ObtenerIdRol(string nombreUser)
        {
            string consulta = "SELECT IdRol FROM Usuario u INNER JOIN UsuarioRol ur ON u.IdUsuario = ur.IdUsuario WHERE u.NombreUser = @NombreUser";
            SqlParameter[] parametros = {
                new SqlParameter("@NombreUser", nombreUser)
            };
            object result = Conexion.EjecutarEscalar2(consulta,parametros);
            return result != null ? Convert.ToInt32(result) : -1;
        }
    }
}
