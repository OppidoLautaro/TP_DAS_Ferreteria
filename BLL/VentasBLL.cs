using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class VentasBLL
    {
        MP_Ventas mP = new MP_Ventas();
        MP_Producto mProduct = new MP_Producto();

        public int RegistrarVenta(Venta venta, List<DetalleVenta> detalles)
        {
            int idVenta = mP.RegistrarVenta(venta);

            foreach (var detalle in detalles)
            {
                detalle.IdVenta = idVenta;
                mP.RegistrarDetalle(detalle);
            }

            return idVenta;
        }

        public int RestarStockProdu(int idproducto, int cantidad)
        {
            mProduct.RestarStockProdu(idproducto, cantidad);
            return idproducto;
        }
    }
    
    
}
