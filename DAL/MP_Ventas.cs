using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MP_Ventas
    {
        Acceso acceso = new Acceso(); // tu clase de acceso a BD

        public int RegistrarVenta(Venta venta)
        {
            SqlParameter[] sqlParameters = new SqlParameter[3];

            sqlParameters[0] = new SqlParameter("@FechaVenta", venta.FechaVenta);
            sqlParameters[1] = new SqlParameter("@MontoTotal", venta.MontoTotal);
            sqlParameters[2] = new SqlParameter("@IDCliente", venta.IDCliente);
            
            DataTable dt = acceso.Leer("P_RegistrarVenta", sqlParameters);

            return Convert.ToInt32(dt.Rows[0]["IDVenta"]);
        }

        public int RegistrarDetalle(DetalleVenta detalle)
        {
            SqlParameter[] parameters = new SqlParameter[4];

            parameters[0] = new SqlParameter("@IDVenta", detalle.IdVenta);
            parameters[1] = new SqlParameter("@IDProducto", detalle.IDProducto);
            parameters[2] = new SqlParameter("@Cantidad", detalle.Cantidad);
            parameters[3] = new SqlParameter("@PrecioUnitario", detalle.PrecioUnitario);

            return acceso.Escribir("P_RegistrarDetalleVenta", parameters);
        }

        public List<Venta> ListarVentas()
        {
            List<Venta> ls = new List<Venta>();

            DataTable dt = acceso.Leer("ListarVentas",null);

            foreach (DataRow dr in dt.Rows) 
            { 
                Venta venta = new Venta();

                venta.IDVenta= Convert.ToInt32(dr["IDVenta"]);
                venta.FechaVenta = Convert.ToDateTime(dr["FechaVenta"]);
                venta.IDCliente = Convert.ToInt32(dr["IDCliente"]);
                venta.MontoTotal = Convert.ToDecimal(dr["MontoTotal"]);

                ls.Add(venta);
            }

            return ls;
        }
    }
}
