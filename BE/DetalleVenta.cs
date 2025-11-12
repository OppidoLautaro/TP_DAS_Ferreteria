using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class DetalleVenta
    {

        private int idVenta;

        public int IdVenta
        {
            get { return idVenta; }
            set { idVenta = value; }
        }

        private int _idProducto;
        public int IDProducto
        {
            get { return _idProducto; }
            set { _idProducto = value; }
        }

        private string _nombreProducto;
        public string NombreProducto
        {
            get { return _nombreProducto; }
            set { _nombreProducto = value; }
        }

        private int _cantidad;
        public int Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }


        public decimal PrecioUnitario
        {
            get { return _precioUnitario; }
            set { _precioUnitario = value; }
        }

        private decimal _precioUnitario;
        public decimal SubTotal
        {
            get { return _precioUnitario * _cantidad; }
        }
    }
}
