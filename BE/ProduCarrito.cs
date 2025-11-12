using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class ProduCarrito
    {
		private Producto producto;

		public  Producto Producto
		{
			get { return producto; }
			set { producto = value; }
		}

		private int cantidad;

		public int Cantidad
		{
			get { return cantidad; }
			set { cantidad = value; }
		}

        public decimal Subtotal => Producto.Precio * Cantidad; 

        public int IDProducto => Producto.IdProducto;
        public decimal PrecioUnitario => Producto.Precio;

        public override string ToString()
        {
            return $"{Producto.Nombre} x{Cantidad} = ${Subtotal}"; // Lo mostramos asi para el Listbox(Carrito)
        }


    }
}
