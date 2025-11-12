using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
	public class Sesion
	{
		private Usuario usuario;

		public Usuario Usuario
		{
			get { return usuario; }
			set { usuario = value; }
		}

		private static Sesion Instancia;
		private Sesion()
		{

		}
		
		public static Sesion GetInstance()
		{
			if (Instancia == null)
			{
				Instancia = new Sesion();
			}
			return Instancia;
		}
		public void SetUsuario(Usuario U)
		{
			usuario = U;
		}

		public void CerrarSesion()
		{
			Usuario = null;
		}


	}
}
