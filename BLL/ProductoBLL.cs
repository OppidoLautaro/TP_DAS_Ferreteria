using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProductoBLL
    {
        MP_Producto mP = new MP_Producto();

        public int AgregarStockProdu(int idProducto, int stock)
        {
            return mP.AgregarStockProdu(idProducto, stock);
        }

        public List<Producto> ListarProductos() 
        { 
            return mP.ListarProductos();
        }

        public int RestarStockProdu(int idProducto, int stock)
        {
            return mP.RestarStockProdu(idProducto, stock);
        }
    }
}
