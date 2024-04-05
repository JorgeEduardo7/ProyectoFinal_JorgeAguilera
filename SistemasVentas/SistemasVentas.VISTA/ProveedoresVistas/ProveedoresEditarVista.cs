using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.ProveedoresVistas
{
    public partial class ProveedoresEditarVista : Form
    {
        int idproveedorx = 0;
        Proveedor proveedor = new Proveedor();
        ProveedorBss bssproveedor = new ProveedorBss();
        public ProveedoresEditarVista(int idproveedor)
        {
            idproveedorx = idproveedor;
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ProveedoresEditarVista_Load(object sender, EventArgs e)
        {
            proveedor = bssproveedor.ObtenerProveedorIdBss(idproveedorx);

            textBox2.Text = proveedor.Nombre;
            textBox1.Text = proveedor.Telefono;
            textBox3.Text = proveedor.Direccion;
            textBox4.Text = proveedor.Estado;

            DataTable datos = bssproveedor.ListarProductoXProveedorBss(idproveedorx);
            foreach (DataRow fila in datos.Rows)
            {
                dataGridView1.Rows.Add(fila["TIPO_PRODUCTO"], fila["MARCA"], fila["NOMBRE"], fila["PRECIO"]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            proveedor.IdProveedor = idproveedorx;
            proveedor.Nombre = textBox2.Text;
            proveedor.Telefono = textBox1.Text;
            proveedor.Direccion = textBox3.Text;
            proveedor.Estado = textBox4.Text;

            bssproveedor.EditarProveedorBss(proveedor);
            MessageBox.Show("Datos Actualizados");
        }
    }
}
