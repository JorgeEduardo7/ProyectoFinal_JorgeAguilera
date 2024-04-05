using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.ClientesVistas;
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

namespace SistemasVentas.VISTA.UsuariosVistas
{
    public partial class UsuariosMostrarVista : Form
    {
        int idusuariox = 0;
        int idpersonax = 0;
        int idusuariorolx = 0;
        int idrolx = 0;
        Usuario usuario = new Usuario();
        UsuarioBss bssusuario = new UsuarioBss();
        Persona persona = new Persona();
        PersonaBss bsspersona = new PersonaBss();
        Rol rol = new Rol();
        RolBss bssrol = new RolBss();
        UsuarioRol usuarioRol = new UsuarioRol();
        UsuarioRolBss bssusuariorol = new UsuarioRolBss();
        public UsuariosMostrarVista(int idusuario, int idpersona, int idusuariorol, int idrol)
        {
            idusuariox = idusuario;
            idpersonax = idpersona;
            idusuariorolx = idusuariorol;
            idrolx = idrol;

            InitializeComponent();
        }

        private void UsuariosMostrarVista_Load(object sender, EventArgs e)
        {
            usuario = bssusuario.ObtenerUsuarioIdBss(idusuariox);
            persona = bsspersona.ObtenerIdBss(idpersonax);
            usuarioRol = bssusuariorol.ObtenerUsuarioRolIdBss(idusuariorolx);
            int idrol2 = usuarioRol.IdRol;
            rol = bssrol.ObtenerRolIdBss(idrol2);

            label5.Text = persona.Nombre;
            label6.Text = usuario.NombreUser;
            label7.Text = usuario.Contraseña;
            dateTimePicker2.Value = usuario.FechaReg;

            label16.Text = persona.Nombre;
            label17.Text = persona.Apellido;
            label18.Text = persona.Telefono;
            label19.Text = persona.Ci;
            label20.Text = persona.Correo;
            label21.Text = persona.Estado;

            label27.Text = rol.Nombre;
            dateTimePicker1.Value = usuarioRol.FechaAsigna;
            label25.Text = usuarioRol.Estado;
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
            int IdUsuarioSeleccionado = idusuariox;
            int IdPersonaSeleccionada = idpersonax;
            int IdUsuarioRolSeleccionado = idusuariorolx;
            int IdRolSeleccionado = idrolx;

            UsuariosEditarVista editarUsuario = new UsuariosEditarVista(IdUsuarioSeleccionado, IdPersonaSeleccionada, IdUsuarioRolSeleccionado, IdRolSeleccionado);
            if (editarUsuario.ShowDialog() == DialogResult.OK)
            {
                UsuariosMostrarVista mostrarVista = new UsuariosMostrarVista(IdUsuarioSeleccionado, IdPersonaSeleccionada, IdUsuarioRolSeleccionado, IdRolSeleccionado);
                mostrarVista.Show();
            }
        }
    }
}
