using SistemasVentas.BSS;
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
    public partial class ProveedoresListarVista : Form
    {
        public ProveedoresListarVista()
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

        ProveedorBss bssproveedor = new ProveedorBss();
        private void ProveedoresListarVista_Load(object sender, EventArgs e)
        {
            DataTable datos = bssproveedor.ListarProveedoresBss();
            foreach (DataRow fila in datos.Rows)
            {
                dataGridView1.Rows.Add(fila["IDPROVEEDOR"], fila["NOMBRE"], fila["TELEFONO"], fila["DIRECCION"], fila["ESTADO"]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdProveedorSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ProveedoresMostrarVista mostrarProveedores = new ProveedoresMostrarVista(IdProveedorSeleccionado);
            mostrarProveedores.Show();
        }
    }
}
