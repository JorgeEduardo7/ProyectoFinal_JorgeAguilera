using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class UsuarioDal
    {
        public DataTable ListarUsuariosDal()
        {
            string consulta = "SELECT USUARIO.IDUSUARIO, PERSONA.IDPERSONA, USUARIOROL.IDUSUARIOROL, ROL.IDROL, " + 
                                     "PERSONA.NOMBRE + ' ' + PERSONA.APELLIDO AS NOMBRE_COMPLETO, USUARIO.NOMBREUSER, ROL.NOMBRE AS ROL, USUARIOROL.ESTADO " +
                               "FROM USUARIO INNER JOIN " +
                                                 "USUARIOROL ON USUARIO.IDUSUARIO = USUARIOROL.IDUSUARIO INNER JOIN " +
                                                 "ROL ON USUARIOROL.IDROL = ROL.IDROL INNER JOIN " +
                                                 "PERSONA ON USUARIO.IDPERSONA = PERSONA.IDPERSONA";

            return Conexion.EjecutarDataTabla(consulta, "Consulta");
        }

        public int InsertarUsuarioDal(Usuario usuario)
        {
            string consulta = "insert into usuario values(" + usuario.IdPersona + "," +
                                                        "'" + usuario.NombreUser + "'," +
                                                        "'" + usuario.Contraseña + "'," +
                                                        "'" + usuario.FechaReg + "')";
            Conexion.Ejecutar(consulta);
            string consulta2 = "select max(idusuario) from usuario";
            int idusuario = Conexion.EjecutarEscalar(consulta2);
            return idusuario;
        }

        public Usuario ObtenerUsuarioId(int id)
        {
            string consulta = "select * from usuario where idusuario = " + id;
            DataTable tabla = Conexion.EjecutarDataTabla(consulta, "asdas");
            Usuario usuario = new Usuario();
            if (tabla.Rows.Count > 0)
            {
                usuario.IdUsuario = Convert.ToInt32(tabla.Rows[0]["idUsuario"]);
                usuario.IdPersona = Convert.ToInt32(tabla.Rows[0]["idPersona"]);
                usuario.NombreUser = tabla.Rows[0]["nombreUser"].ToString();
                usuario.Contraseña = tabla.Rows[0]["contraseña"].ToString();
                usuario.FechaReg = Convert.ToDateTime(tabla.Rows[0]["fechaReg"]);
            }
            return usuario;
        }

        public void EditarUsuarioDal(Usuario usuario)
        {
            string consulta = "update usuario set idpersona =" + usuario.IdPersona + "," +
                                                 "nombreUser ='" + usuario.NombreUser + "'," +
                                                 "contraseña ='" + usuario.Contraseña + "'," +
                                                 "fechaReg ='" + usuario.FechaReg + "' " +
                                    "where idusuario=" + usuario.IdUsuario;

            Conexion.Ejecutar(consulta);
        }

        public void EliminarUsuarioDal(int id)
        {
            string consulta = "delete from usuario where idusuario =" + id;
            Conexion.Ejecutar(consulta);
        }
    }
}
