using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public class MP_Cliente
    {
        Acceso acc = new Acceso();

        public int AltaCliente(BE.Cliente c)
        {
            int fa = 0;

            SqlParameter[] parameters = new SqlParameter[6];
            parameters[0] = new SqlParameter("@Nombre", c.Nombre);
            parameters[1] = new SqlParameter("@Apellido", c.Apellido);
            parameters[2] = new SqlParameter("@DNI", c.DNI);
            parameters[3] = new SqlParameter("@Email", c.Email);
            parameters[4] = new SqlParameter("@Telefono", c.Telefono);
            parameters[5] = new SqlParameter("@Direccion", c.Direccion);

            fa = acc.Escribir("AltaCliente", parameters);
            return fa;
        }


        public List<BE.Cliente> ListarClientes() 
        { 
            List<BE.Cliente> ls = new List<BE.Cliente>();

            DataTable dt = acc.Leer("ListarClientes", null);


            foreach (DataRow dr in dt.Rows)
            {
                BE.Cliente cliente = new BE.Cliente();

                cliente.Apellido = dr["Apellido"].ToString();
                cliente.Nombre = dr["Nombre"].ToString();
                cliente.DNI = dr["DNI"].ToString();
                cliente.Email = dr["Email"].ToString();
                cliente.Telefono = dr["Telefono"].ToString();
                cliente.Direccion = dr["Direccion"].ToString();
                
                ls.Add(cliente);
            } 


            return ls;
        }

    }
}
