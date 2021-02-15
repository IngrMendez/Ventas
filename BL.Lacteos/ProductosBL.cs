using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BL.Lacteos
{
    public class ProductosBL
    {
        public BindingList<Producto> ListaProductos { get; set; }
        public ProductosBL()
        {
            ListaProductos = new BindingList<Producto>();

            var producto1 = new Producto();
            producto1.Id = 1;
            producto1.Descripcion = "Queso Semiseco";
            producto1.Precio = 30;
            producto1.Existencia = 20;
            producto1.Activo = true;

            ListaProductos.Add(producto1);

            var producto2 = new Producto();
            producto2.Id = 2;
            producto2.Descripcion = "Queso Frijolero";
            producto2.Precio = 18;
            producto2.Existencia = 9;
            producto2.Activo = true;

            ListaProductos.Add(producto2);


            var producto3 = new Producto();
            producto3.Id = 3;
            producto3.Descripcion = "Quesillo";
            producto3.Precio = 12;
            producto3.Existencia = 14;
            producto3.Activo = true;

            ListaProductos.Add(producto3);

            var producto4 = new Producto();
            producto4.Id = 4;
            producto4.Descripcion = "Mantequilla";
            producto4.Precio = 12;
            producto4.Existencia = 20;
            producto4.Activo = true;

            ListaProductos.Add(producto4);

            var producto5 = new Producto();
            producto5.Id = 5;
            producto5.Descripcion = "Leche Entera";
            producto5.Precio = 25;
            producto5.Existencia = 50;
            producto5.Activo = true;

            ListaProductos.Add(producto5);

        }

        public BindingList<Producto> ObtenerProductos()
        {



            return ListaProductos;

        }
    }

    public class Producto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Existencia { get; set; }
        public bool Activo { get; set; }
    }
}