using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BLL
{
    public class UsuarioBLL
    {
        MP_Usuario mapper = new MP_Usuario();

        public Usuario Login(string user, string pass)
        {
            return mapper.Login(user, pass);
        }
    }
}
