using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class MP_Usuario
    {
        Acceso acc = new Acceso();

        public Usuario Login(string Nombre, string Contraseña)
        {
            Usuario user = null;

            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@Username",Nombre);
            parameters[1] = new SqlParameter("@Contraseña", Contraseña);

            DataTable dt = acc.Leer("LoginUsuario", parameters);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];

                user = new Usuario();
                user.IDUsuario = Convert.ToInt32(row["IDUsuario"]);
                user.Username = row["Nombre"].ToString();
                user.Contraseña = row["Contraseña"].ToString();

                user.Rol = new Rol();
                user.Rol.IDRol = Convert.ToInt32(row["IDRol"]);
                user.Rol.NombreRol = row["Rol"].ToString();
            }

            return user;
        }
    }
}
