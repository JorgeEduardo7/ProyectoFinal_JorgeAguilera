using SistemasVentas.BSS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.ProductosVistas
{
    public partial class ProductosListarVista : Form
    {
        public ProductosListarVista()
        {
            InitializeComponent();
        }

        ProductoBss bssproducto = new ProductoBss();
        private void ProductosListarVista_Load(object sender, EventArgs e)
        {
            DataTable datos = bssproducto.ListarProductosBss();
            foreach (DataRow fila in datos.Rows)
            {
                dataGridView1.Rows.Add(fila["IDTIPOPROD"], fila["IDMARCA"], fila["IDPRODUCTO"], fila["IDDETALLEING"], fila["PRODUCTO"], fila["FECHADEVENCIMIENTO"], fila["PRECIOCOSTO"], fila["PRECIOVENTA"], fila["STOCK"]);
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

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
