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

namespace Win.Lacteos
{
    public partial class FormProductos : Form
    {
        ProductosBL _productos;

        public FormProductos()
        {
            InitializeComponent();

            _productos = new ProductosBL();
            listaProductosBindingSource1.DataSource = _productos.ObtenerProductos();
        }

        private void listaProductosBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaProductosBindingSource1.EndEdit();
            var producto = (Producto)listaProductosBindingSource1.Current ;

            var resultado = _productos.GuardarProducto(producto);

            if (resultado == true)
                {
                listaProductosBindingSource1.ResetBindings(false);
                }

            else
               {
                MessageBox.Show("Ocurrio un error guardando el producto");

            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _productos.AgregarProducto();
            listaProductosBindingSource1.MoveLast();
        }
    }
}