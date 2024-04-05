using SistemasVentas.BSS;
using SistemasVentas.VISTA.RolVistas;
using SistemasVentas.VISTA.UsuarioRolVistas;
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

namespace SistemasVentas.VISTA.RolesVistas
{
    public partial class RolesListarVista : Form
    {
        public RolesListarVista()
        {
            InitializeComponent();
        }
        RolBss bssrol = new RolBss();
        private void RolesListarVista_Load(object sender, EventArgs e)
        {
            DataTable datos = bssrol.ListarRolesBss();
            foreach (DataRow fila in datos.Rows)
            {
                dataGridView1.Rows.Add(fila["IDROL"], fila["NOMBRE"], fila["ESTADO"]);
            }
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
            RolesInsertarVista insertarVista = new RolesInsertarVista();
            if (insertarVista.ShowDialog() == DialogResult.OK)
            {
                RolesListarVista fr = new RolesListarVista();
                fr.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UsuariosEditarVista.IdRolSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            UsuariosInsertarVista.IdRolSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }
    }
}
