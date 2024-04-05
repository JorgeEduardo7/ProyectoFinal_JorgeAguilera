using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.BienvenidoVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.LoginVistas
{
    public partial class LoginVista : Form
    {
        private LoginBss loginBss;

        public LoginVista()
        {
            InitializeComponent();
            loginBss = new LoginBss();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreUser = textBox1.Text;
            string contraseña = textBox2.Text;

            if (loginBss.IniciarSesion(nombreUser, contraseña))
            {
                int idRol = loginBss.ObtenerRolUsuario(nombreUser);

                switch (idRol)
                {
                    case 1: // GERENTE
                        BienvenidoGerenteVista gerente = new BienvenidoGerenteVista();
                        gerente.Show();
                        break;
                    case 2: // SUPERVISOR
                        BienvenidoSupervisorVista supervisor = new BienvenidoSupervisorVista();
                        supervisor.Show();
                        break;
                    case 3: // CAJERO
                        BienvenidoCajeroVista cajero = new BienvenidoCajeroVista();
                        cajero.Show();
                        break;
                    default:
                        MessageBox.Show("El usuario no tiene un rol asignado.");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos.");
            }
        }

        private void icon_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
