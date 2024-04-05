using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class ProductoDal
    {
        public DataTable ListarProductosDal()
        {
            string consulta = "SELECT TIPOPROD.IDTIPOPROD, MARCA.IDMARCA, PRODUCTO.IDPRODUCTO, DETALLEING.IDDETALLEING, PRODUCTO.NOMBRE AS PRODUCTO, " +
                                     "DETALLEING.FECHAVENC AS FECHADEVENCIMIENTO, DETALLEING.PRECIOCOSTO AS PRECIOCOSTO, DETALLEING.PRECIOVENTA AS PRECIOVENTA, " +
                                     "DETALLEING.CANTIDAD AS STOCK " +
                              "FROM PRODUCTO INNER JOIN " +
                                        "MARCA ON PRODUCTO.IDMARCA = MARCA.IDMARCA INNER JOIN " +
                                        "DETALLEING ON PRODUCTO.IDPRODUCTO = DETALLEING.IDPRODUCTO INNER JOIN " +
                                        "INGRESO ON DETALLEING.IDINGRESO = INGRESO.IDINGRESO INNER JOIN " +
                                        "TIPOPROD ON PRODUCTO.IDTIPOPROD = TIPOPROD.IDTIPOPROD ";

            return Conexion.EjecutarDataTabla(consulta, "Consulta");
        }

        public void InsertarProductoDal(Producto producto)
        {
            string consulta = "insert into producto values(" + producto.IdTipoProd + "," +
                                                         "" + producto.IdMarca + "," +
                                                         "'" + producto.Nombre + "'," +
                                                         "'" + producto.CodigoBarra + "'," +
                                                         "" + producto.Unidad + "," +
                                                         "'" + producto.Descripcion + "'," +
                                                         "'" + producto.Estado + "')";
            Conexion.Ejecutar(consulta);
        }

        public Producto ObtenerProductoId(int id)
        {
            string consulta = "select * from producto where idproducto = " + id;
            DataTable tabla = Conexion.EjecutarDataTabla(consulta, "asdas");
            Producto producto = new Producto();
            if (tabla.Rows.Count > 0)
            {
                producto.IdProducto = Convert.ToInt32(tabla.Rows[0]["idProducto"]);
                producto.IdTipoProd = Convert.ToInt32(tabla.Rows[0]["idTipoProd"]);
                producto.IdMarca = Convert.ToInt32(tabla.Rows[0]["idMarca"]);
                producto.Nombre = tabla.Rows[0]["nombre"].ToString();
                producto.CodigoBarra = tabla.Rows[0]["codigoBarra"].ToString();
                producto.Unidad = Convert.ToInt32(tabla.Rows[0]["Unidad"]);
                producto.Descripcion = tabla.Rows[0]["descripcion"].ToString();
                producto.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return producto;
        }

        public void EditarProductoDal(Producto producto)
        {
            string consulta = "update producto set idTipoProd =" + producto.IdTipoProd + "," +
                                                 "idMarca =" + producto.IdMarca + "," +
                                                 "nombre ='" + producto.Nombre + "'," +
                                                 "codigoBarra ='" + producto.CodigoBarra + "'," +
                                                 "unidad =" + producto.Unidad + "," +
                                                 "descripcion ='" + producto.Descripcion + "'," +
                                                 "estado ='" + producto.Estado + "' " +
                                    "where idproducto=" + producto.IdProducto;

            Conexion.Ejecutar(consulta);
        }

        public void EliminarProductoDal(int id)
        {
            string consulta = "delete from producto where idproducto =" + id;
            Conexion.Ejecutar(consulta);
        }
    }
}
