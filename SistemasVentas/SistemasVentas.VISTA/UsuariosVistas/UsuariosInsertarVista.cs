using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.RolesVistas;
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
    public partial class UsuariosInsertarVista : Form
    {
        Rol rol = new Rol();
        RolBss bssrol = new RolBss();
        public UsuariosInsertarVista()
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

        public static int IdRolSeleccionado = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            RolesListarVista listarVista = new RolesListarVista();
            if (listarVista.ShowDialog() == DialogResult.OK)
            {
                rol = bssrol.ObtenerRolIdBss(IdRolSeleccionado);
                textBox1.Text = rol.Nombre;
            }
        }

        PersonaBss bsspersona = new PersonaBss();
        UsuarioBss bssusuario = new UsuarioBss();
        UsuarioRolBss bssusuariorol = new UsuarioRolBss();
        private void button3_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();

            persona.Nombre = textBox5.Text;
            persona.Apellido = textBox6.Text;
            persona.Telefono = textBox7.Text;
            persona.Ci = textBox8.Text;
            persona.Correo = textBox9.Text;
            persona.Estado = textBox10.Text;

            int idpersona = bsspersona.InsertarPersonaBss(persona);

            Usuario usuario = new Usuario();

            usuario.IdPersona = idpersona;
            usuario.NombreUser = textBox2.Text;
            usuario.Contraseña = textBox3.Text;
            usuario.FechaReg = dateTimePicker2.Value;

            int idusuario = bssusuario.InsertarUsuarioBss(usuario);

            UsuarioRol usuarioRol = new UsuarioRol();

            usuarioRol.IdUsuario = idusuario;
            usuarioRol.IdRol = IdRolSeleccionado;
            usuarioRol.Estado = textBox10.Text;
            usuarioRol.FechaAsigna = dateTimePicker2.Value;

            bssusuariorol.InsertarUsuarioRolBss(usuarioRol);
            MessageBox.Show("Se guardaron correctamente la Persona y el Usuario.");
        }
    }
}
