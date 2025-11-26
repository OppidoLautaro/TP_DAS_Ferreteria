using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BLL
{
    public class VentasBLL
    {
        MP_Ventas mp = new MP_Ventas();
        MP_Producto mProduct = new MP_Producto();


        public List<Venta> listarVentas()
        {
            return mp.ListarVentas();
        }


        public int RegistrarVenta(Venta venta, List<DetalleVenta> detalles)
        {
            int idVenta = mp.RegistrarVenta(venta);

            foreach (DetalleVenta detalle in detalles)
            {
                detalle.IdVenta = idVenta;
                mp.RegistrarDetalle(detalle);
            }

            return idVenta;
        }

        public int RestarStockProdu(int idproducto, int cantidad)
        {
            mProduct.RestarStockProdu(idproducto, cantidad);
            return idproducto;
        }


        public void GenerarXMLVenta(int idVenta)
        {
            DataTable venta = mp.ObtenerVenta(idVenta);
            DataTable detalles = mp.ObtenerDetallesVenta(idVenta);

            if (venta.Rows.Count == 0)
                throw new Exception("La venta no existe.");

            XDocument xml = new XDocument(
                new XElement("Venta",
                    new XElement("IDVenta", venta.Rows[0]["IDVenta"]),
                    new XElement("FechaVenta", venta.Rows[0]["FechaVenta"]),
                    new XElement("IDCliente", venta.Rows[0]["IDCliente"]),
                    new XElement("MontoTotal", venta.Rows[0]["MontoTotal"]),

                    new XElement("Detalles",
                        from DataRow dr in detalles.Rows
                        select new XElement("Detalle",
                            new XElement("IDProducto", dr["IDProducto"]),
                            new XElement("Nombre", dr["Nombre"]),
                            new XElement("Cantidad", dr["Cantidad"]),
                            new XElement("PrecioUnitario", dr["PrecioUnitario"]),
                            new XElement("Subtotal", dr["Subtotal"])
                        )
                    )
                )
            );

            string destino = $"Venta_{idVenta}.xml";
            xml.Save(destino);
        }

    }
    
}
