using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Producto
    {
		private int idProducto;

		public int IdProducto
		{
			get { return idProducto; }
			set { idProducto = value; }
		}

		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		private string descripcion;

		public string Descripcion
		{
			get { return descripcion; }
			set { descripcion = value; }
		}

		private decimal precio;

		public decimal Precio
		{
			get { return precio; }
			set { precio = value; }
		}

		private int stock;

		public int Stock
		{
			get { return stock; }
			set { stock = value; }
		}


	}
}
