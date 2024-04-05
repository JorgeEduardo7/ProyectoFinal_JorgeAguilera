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

namespace SistemasVentas.VISTA.ClientesVistas
{
    public partial class ClientesMostrarVista : Form
    {
        int idclientex = 0;
        int idpersonax = 0;
        Cliente cliente = new Cliente();
        ClienteBss bsscliente = new ClienteBss();
        Persona persona = new Persona();
        PersonaBss bsspersona = new PersonaBss();
        public ClientesMostrarVista(int idcliente, int idpersona)
        {
            idclientex = idcliente;
            idpersonax = idpersona;
            InitializeComponent();
        }

        private void ClientesMostrarVista_Load(object sender, EventArgs e)
        {
            cliente = bsscliente.ObtenerClienteIdBss(idclientex);
            persona = bsspersona.ObtenerIdBss(idpersonax);

            label5.Text = persona.Nombre;
            label6.Text = cliente.TipoCliente;
            label7.Text = cliente.CodigoCliente;
            label8.Text = cliente.Estado;

            label16.Text = persona.Nombre;
            label17.Text = persona.Apellido;
            label18.Text = persona.Telefono;
            label19.Text = persona.Ci;
            label20.Text = persona.Correo;
            label21.Text = persona.Estado;
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
            int IdClienteSeleccionado = idclientex;
            int IdPersonaSeleccionada = idpersonax;
            ClientesEditarVista editarCliente = new ClientesEditarVista(IdClienteSeleccionado, IdPersonaSeleccionada);
            if (editarCliente.ShowDialog() == DialogResult.OK)
            {
                ClientesMostrarVista mostrarVista = new ClientesMostrarVista(IdClienteSeleccionado, IdPersonaSeleccionada);
                mostrarVista.Show();
            }
        }
    }
}
