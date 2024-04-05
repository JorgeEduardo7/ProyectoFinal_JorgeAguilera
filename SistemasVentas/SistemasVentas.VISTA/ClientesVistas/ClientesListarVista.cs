using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.BienvenidoVistas;
using SistemasVentas.VISTA.ClienteVistas;
using SistemasVentas.VISTA.MenuVistas;
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

namespace SistemasVentas.VISTA.ClientesVistas
{
    public partial class ClientesListarVista : Form
    {
        public ClientesListarVista()
        {
            InitializeComponent();
        }
        ClienteBss bsscliente = new ClienteBss();
        PersonaBss bsspersona = new PersonaBss();
        private void ClientesListarVista_Load(object sender, EventArgs e)
        {
            DataTable datos = bsscliente.ListarClientesBss();
            foreach (DataRow fila in datos.Rows)
            {
                dataGridView1.Rows.Add(fila["IDCLIENTE"], fila["IDPERSONA"], fila["NOMBRE_COMPLETO"], fila["TIPOCLIENTE"], fila["CODIGOCLIENTE"], fila["ESTADO"]);
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
            ClientesInsertarVista insertarCliente = new ClientesInsertarVista();

            if (insertarCliente.ShowDialog() == DialogResult.OK)
            {
                int ultimoIdCliente = bsscliente.ObtenerUltimoClienteIdBss();
                int ultimoIdPersona = bsspersona.ObtenerUltimoPersonaIdBss();
                ClientesMostrarVista mostrarVista = new ClientesMostrarVista(ultimoIdCliente, ultimoIdPersona);
                mostrarVista.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdClienteSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            int IdPersonaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);
            ClientesMostrarVista mostrarClientes = new ClientesMostrarVista(IdClienteSeleccionado, IdPersonaSeleccionada);
            mostrarClientes.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuGerenteVista menuJefe = new MenuGerenteVista();
            menuJefe.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
