using BL.Lacteos;
using System;
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

            if (resultado.Exitoso == true)
                {
                listaProductosBindingSource1.ResetBindings(false);
                DesabilitarHabilitarBotones(true);
            }

            else
               {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _productos.AgregarProducto();
            listaProductosBindingSource1.MoveLast();

            DesabilitarHabilitarBotones(false);
        }

        private void DesabilitarHabilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;

            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            toolStripButton1Cancelar.Visible = !valor;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

                if (idTextBox.Text != "")

                {
                var resultado = MessageBox.Show("Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                    Eliminar(id);
                }
            }      
        }

        private void Eliminar(int id)
        {
            var resultado = _productos.EliminarProducto(id);

            if (resultado == true)
            {
                listaProductosBindingSource1.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar el producto");
            }
        }

        private void toolStripButton1Cancelar_Click(object sender, EventArgs e)
        {
            DesabilitarHabilitarBotones(true);
            Eliminar(0);
        }
    }
}