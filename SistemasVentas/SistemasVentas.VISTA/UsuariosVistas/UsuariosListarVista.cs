using SistemasVentas.BSS;
using SistemasVentas.VISTA.ClientesVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.UsuariosVistas
{
    public partial class UsuariosListarVista : Form
    {
        public UsuariosListarVista()
        {
            InitializeComponent();
        }
        UsuarioBss bssusuario = new UsuarioBss();
        private void UsuariosListarVista_Load(object sender, EventArgs e)
        {
            DataTable datos = bssusuario.ListarUsuariosBss();
            foreach (DataRow fila in datos.Rows)
            {
                dataGridView1.Rows.Add(fila["IDUSUARIO"], fila["IDPERSONA"], fila["IDUSUARIOROL"], fila["IDROL"], fila["NOMBRE_COMPLETO"], fila["NOMBREUSER"], fila["ROL"], fila["ESTADO"]);
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
            UsuariosInsertarVista insertarUsuario = new UsuariosInsertarVista();

            if (insertarUsuario.ShowDialog() == DialogResult.OK)
            {
                UsuariosListarVista fr = new UsuariosListarVista();
                fr.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdUsuarioSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            int IdPersonaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);
            int IdUsuarioRolSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);
            int IdRolSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value);
            UsuariosMostrarVista mostrarUsuarios = new UsuariosMostrarVista(IdUsuarioSeleccionado, IdPersonaSeleccionada, IdUsuarioRolSeleccionado, IdRolSeleccionado);
            mostrarUsuarios.Show();
        }

    }
}
