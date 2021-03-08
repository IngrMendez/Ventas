using BL.Lacteos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinLacteos
{
    public partial class FormProductos : Form
    {
     
        ProductosBL _productos;

        public FormProductos()
        {
            InitializeComponent();

            _productos = new ProductosBL();
           listaProductosBindingSource.DataSource= _productos.ObtenerProductos();
        }

        private void productoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            var producto = (Producto)listaProductosBindingSource.Current;
            
        }
    }
}
