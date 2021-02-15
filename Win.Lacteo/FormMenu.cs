using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.Lacteo
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            var formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formClientes = new FormClientes();
            formClientes.MdiParent = this;
            formClientes.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            login();
        }

        private void reporteDeLacteosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listaDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var formProductos = new FormProductos();
            formProductos.MdiParent = this;
            formProductos.Show();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
