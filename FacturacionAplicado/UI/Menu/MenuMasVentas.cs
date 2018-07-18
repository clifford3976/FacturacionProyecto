using FacturacionAplicado.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using FacturacionAplicado.UI.Consultas;

namespace FacturacionAplicado.UI.Menu
{
    public partial class MenuMasVentas : Form
    {
        public MenuMasVentas()
        {
            InitializeComponent();
            ConexionGlobal.ConexionGlobalDb.TestConnectiong();
        }
        



        private void crearClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rClientes abrir = new rClientes();
            abrir.MdiParent = this;
            abrir.Show();
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rDepartamento abrir = new rDepartamento();
            abrir.MdiParent = this;
            abrir.Show();
        }

        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rFacturacion abrir = new rFacturacion();
            abrir.MdiParent = this;
            abrir.Show();
        }

        private void crearUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rUsuario abrir = new rUsuario();
            abrir.MdiParent = this;
            abrir.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rProducto abrir = new rProducto();
            abrir.MdiParent = this;
            abrir.Show();
                
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CFactura abrir = new CFactura();
            abrir.MdiParent = this;
            abrir.Show();
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CProducto abrir = new CProducto();
            abrir.MdiParent = this;
            abrir.Show();

        }

        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CDepartamento abrir = new CDepartamento();
            abrir.MdiParent = this;
            abrir.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cusuario abrir = new Cusuario();
            abrir.MdiParent = this;
            abrir.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cClientes abrir = new cClientes();
            abrir.MdiParent = this;
            abrir.Show();
        }
    }
}
