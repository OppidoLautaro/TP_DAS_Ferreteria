using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Venta
    {
        private int _idVenta;
        public int IDVenta
        {
            get { return _idVenta; }
            set { _idVenta = value; }
        }

        private DateTime _fechaVenta;
        public DateTime FechaVenta
        {
            get { return _fechaVenta; }
            set { _fechaVenta = value; }
        }

        private decimal _montoTotal;
        public decimal MontoTotal
        {
            get { return _montoTotal; }
            set { _montoTotal = value; }
        }

        private int _idCliente;
        public int IDCliente
        {
            get { return _idCliente; }
            set { _idCliente = value; }
        }
    }
}
