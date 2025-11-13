using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Cliente
    {


		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		private string apellido;

		public string Apellido
		{
			get { return apellido; }
			set { apellido = value; }
		}

		private string dni;

		public string DNI
		{
			get { return dni; }
			set { dni = value; }
		}

		private string email;

		public string Email
		{
			get { return email; }
			set { email = value; }
		}

		private string telefono;

		public string Telefono
		{
			get { return telefono; }
			set { telefono = value; }
		}

		private string direccion;

		public string Direccion
		{
			get { return direccion; }
			set { direccion = value; }
		}
	}
}
