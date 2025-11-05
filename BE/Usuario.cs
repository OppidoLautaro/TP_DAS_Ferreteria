using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Usuario
    {

		private int idUsuario;

		public int IDUsuario
		{
			get { return idUsuario; }
			set { idUsuario = value; }
		}


		private string username;

		public string Username
		{
			get { return username; }
			set { username = value; }
		}

		private string contraseña;

		public string Contraseña
		{
			get { return contraseña; }
			set { contraseña = value; }
		}

		private Rol rol;

		public Rol Rol
		{
			get { return rol; }
			set { rol = value; }
		}

	}
}
