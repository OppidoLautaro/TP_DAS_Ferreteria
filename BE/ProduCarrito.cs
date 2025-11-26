using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class ProduCarrito
    {
        public Producto Producto { get; set; }

        public int Cantidad { get; set; }

        public int IDProducto => Producto?.IdProducto ?? 0;

        public decimal PrecioUnitario => Producto?.Precio ?? 0;

        public decimal Subtotal => PrecioUnitario * Cantidad;

        public override string ToString()
        {
            return $"{Producto.Nombre} x{Cantidad} = ${Subtotal}";
        }

    }
}
