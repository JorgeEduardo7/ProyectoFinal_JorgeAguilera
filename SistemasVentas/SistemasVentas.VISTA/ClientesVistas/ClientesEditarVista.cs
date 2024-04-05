using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.ClienteVistas;
using SistemasVentas.VISTA.MenuVistas;
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

namespace SistemasVentas.VISTA.ClientesVistas
{
    public partial class ClientesEditarVista : Form
    {
        int idclientex = 0;
        int idpersonax = 0;
        Persona persona = new Persona();
        PersonaBss bsspersona = new PersonaBss();
        Cliente cliente = new Cliente();
        ClienteBss bsscliente = new ClienteBss();
        public ClientesEditarVista(int idcliente, int idpersona)
        {
            idclientex = idcliente;
            idpersonax = idpersona;
            InitializeComponent();
        }

        private void ClientesEditarVista_Load(object sender, EventArgs e)
        {
            cliente = bsscliente.ObtenerClienteIdBss(idclientex);
            persona = bsspersona.ObtenerIdBss(idpersonax);

            label5.Text = Convert.ToString(persona.Nombre);
            textBox2.Text = cliente.TipoCliente;
            textBox3.Text = cliente.CodigoCliente;
            textBox4.Text = cliente.Estado;

            textBox5.Text = persona.Nombre;
            textBox6.Text = persona.Apellido;
            textBox7.Text = persona.Telefono;
            textBox8.Text = persona.Ci;
            textBox9.Text = persona.Correo;
            textBox10.Text = persona.Estado;

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
            cliente.IdPersona = idpersonax;
            cliente.TipoCliente = textBox2.Text;
            cliente.CodigoCliente = textBox3.Text;
            cliente.Estado = textBox4.Text;

            persona.Nombre = textBox5.Text;
            persona.Apellido = textBox6.Text;
            persona.Telefono = textBox7.Text;
            persona.Ci = textBox8.Text;
            persona.Correo = textBox9.Text;
            persona.Estado = textBox10.Text;

            bsspersona.EditarPersonaBss(persona);
            bsscliente.EditarClienteBss(cliente);

            MessageBox.Show("Datos Actualizados");

        }
    }
}
