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

namespace SistemasVentas.VISTA.ClientesVistas
{
    public partial class ClientesInsertarVista : Form
    {
        public ClientesInsertarVista()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        PersonaBss bsspersona = new PersonaBss();
        ClienteBss bsscliente = new ClienteBss();

        private void button1_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();

            persona.Nombre = textBox5.Text;
            persona.Apellido = textBox6.Text;
            persona.Telefono = textBox7.Text;
            persona.Ci = textBox8.Text;
            persona.Correo = textBox9.Text;
            persona.Estado = textBox10.Text;

            int id = bsspersona.InsertarPersonaBss(persona);

            Cliente cliente = new Cliente();

            cliente.IdPersona = id;
            cliente.TipoCliente = textBox2.Text;
            cliente.CodigoCliente = textBox3.Text;
            cliente.Estado = textBox10.Text;

            bsscliente.InsertarClienteBss(cliente);
            MessageBox.Show("Se guardaron correctamente la Persona y cliente.");
        }
    }
}
