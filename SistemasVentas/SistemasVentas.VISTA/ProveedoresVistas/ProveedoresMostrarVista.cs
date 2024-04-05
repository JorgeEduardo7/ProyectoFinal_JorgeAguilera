using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.UsuariosVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.ProveedoresVistas
{
    public partial class ProveedoresMostrarVista : Form
    {
        int idproveedorx = 0;
        Proveedor proveedor = new Proveedor();
        ProveedorBss bssproveedor = new ProveedorBss();
        public ProveedoresMostrarVista(int idproveedor)
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

        private void ProveedoresMostrarVista_Load(object sender, EventArgs e)
        {
            proveedor = bssproveedor.ObtenerProveedorIdBss(idproveedorx);

            label5.Text = proveedor.Nombre;
            label6.Text = proveedor.Telefono;
            label7.Text = proveedor.Direccion;
            label8.Text = proveedor.Estado;

            DataTable datos = bssproveedor.ListarProductoXProveedorBss(idproveedorx);
            foreach (DataRow fila in datos.Rows)
            {
                dataGridView1.Rows.Add(fila["TIPO_PRODUCTO"], fila["MARCA"], fila["NOMBRE"], fila["PRECIO"]);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProveedoresEditarVista editarProveedor = new ProveedoresEditarVista(idproveedorx);
            if (editarProveedor.ShowDialog() == DialogResult.OK)
            {
                ProveedoresMostrarVista mostrarVista = new ProveedoresMostrarVista(idproveedorx);
                mostrarVista.Show();
            }
        }
    }
}
