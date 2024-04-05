using SistemasVentas.VISTA.ClientesVistas;
using SistemasVentas.VISTA.ProductosVistas;
using SistemasVentas.VISTA.ProveedoresVistas;
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

namespace SistemasVentas.VISTA.MenuVistas
{
    public partial class MenuGerenteVista : Form
    {
        public MenuGerenteVista()
        {
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

        private void button1_Click(object sender, EventArgs e)
        {
            ClientesListarVista listarClientes = new ClientesListarVista();
            listarClientes.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UsuariosListarVista listarUsuarios = new UsuariosListarVista();
            listarUsuarios.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProveedoresListarVista listarProveedores = new ProveedoresListarVista();
            listarProveedores.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProductosListarVista listarProductos = new ProductosListarVista();
            listarProductos.Show();
        }
    }
}
