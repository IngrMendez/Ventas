using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.Lacteos
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            Login();
    }

        private void Login()
        {
            var formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            var formProductos = new FormProductos();
            formProductos.MdiParent = this;
            formProductos.Show();

          }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            var formClientes = new FormClientes();
            formClientes.MdiParent = this;
            formClientes.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            Login();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            var formProductos = new FormProductos();
            formProductos.MdiParent = this;
            formProductos.Show();

        }
    }
    }
