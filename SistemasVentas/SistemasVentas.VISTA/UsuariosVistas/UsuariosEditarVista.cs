using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.RolesVistas;
using SistemasVentas.VISTA.RolVistas;
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
    public partial class UsuariosEditarVista : Form
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
        public UsuariosEditarVista(int idusuario, int idpersona, int idusuariorol, int idrol)
        {
            idusuariox = idusuario;
            idpersonax = idpersona;
            idusuariorolx = idusuariorol;
            idrolx = idrol;

            InitializeComponent();
        }

        public void UsuariosEditarVista_Load(object sender, EventArgs e)
        {
            usuario = bssusuario.ObtenerUsuarioIdBss(idusuariox);
            persona = bsspersona.ObtenerIdBss(idpersonax);
            usuarioRol = bssusuariorol.ObtenerUsuarioRolIdBss(idusuariorolx);
            int idrol2 = usuarioRol.IdRol;
            rol = bssrol.ObtenerRolIdBss(idrol2);

            label5.Text = persona.Nombre;
            textBox2.Text = usuario.NombreUser;
            textBox3.Text = usuario.Contraseña;
            dateTimePicker2.Value = usuario.FechaReg;

            textBox5.Text = persona.Nombre;
            textBox6.Text = persona.Apellido;
            textBox7.Text = persona.Telefono;
            textBox8.Text = persona.Ci;
            textBox9.Text = persona.Correo;
            textBox10.Text = persona.Estado;

            textBox1.Text = rol.Nombre;
            dateTimePicker1.Value = usuarioRol.FechaAsigna;
            textBox4.Text = usuarioRol.Estado;
        }
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public static int  IdRolSeleccionado = 0;
        public void button4_Click(object sender, EventArgs e)
        {
            RolesListarVista listarVista = new RolesListarVista();
            if (listarVista.ShowDialog() == DialogResult.OK)
            {
                rol = bssrol.ObtenerRolIdBss(IdRolSeleccionado);
                textBox1.Text = rol.Nombre;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            persona.Nombre = textBox5.Text;
            persona.Apellido = textBox6.Text;
            persona.Telefono = textBox7.Text;
            persona.Ci = textBox8.Text;
            persona.Correo = textBox9.Text;
            persona.Estado = textBox10.Text;

            usuario.IdPersona = idpersonax;
            usuario.NombreUser = textBox2.Text;
            usuario.Contraseña = textBox3.Text;
            usuario.FechaReg = dateTimePicker2.Value;

            usuarioRol.IdRol = IdRolSeleccionado;
            usuarioRol.FechaAsigna = dateTimePicker1.Value;
            usuarioRol.Estado = textBox4.Text;

            bsspersona.EditarPersonaBss(persona);
            bssusuario.EditarUsuarioBss(usuario);
            bssusuariorol.EditarUsuarioRolBss(usuarioRol);

            MessageBox.Show("Datos Actualizados");
        }
    }
}
