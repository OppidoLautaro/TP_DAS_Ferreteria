using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BE;

namespace BLL
{
    public class ClienteBLL
    {
        MP_Cliente mapper = new MP_Cliente();

        public int AgregarCliente(BE.Cliente c)
        {
            return mapper.AltaCliente(c);
        }

        public List<BE.Cliente> ListarClientes()
        {
            return mapper.ListarClientes();
        }
    }
}
