using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemasVentas.VISTA.RolesVistas
{
    public partial class RolesInsertarVista : Form
    {
        public RolesInsertarVista()
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

        RolBss bssrol = new RolBss();
        private void button3_Click(object sender, EventArgs e)
        {
            Rol rol = new Rol();
            rol.Nombre = textBox5.Text;
            rol.Estado = textBox8.Text;

            bssrol.InsertarRolBss(rol);
            MessageBox.Show("Se guardo correctamente el Rol");
        }
    }
}
