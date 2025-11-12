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
            SqlParameter[] parameters = new SqlParameter[4];

            parameters[0] = new SqlParameter("@FechaVenta", venta.FechaVenta);
            parameters[1] = new SqlParameter("@MontoTotal", venta.MontoTotal);
            parameters[2] = new SqlParameter("@IDCliente", venta.IDCliente);

            SqlParameter outputParam = new SqlParameter("@IDVenta", SqlDbType.Int);
            outputParam.Direction = ParameterDirection.Output;
            parameters[3] = outputParam;

            acceso.Escribir("P_RegistrarVenta", parameters);

            return Convert.ToInt32(outputParam.Value);
        }

        public int RegistrarDetalle(DetalleVenta detalle)
        {
            SqlParameter[] parameters = new SqlParameter[3];

            parameters[0] = new SqlParameter("@IDProducto", detalle.IDProducto);
            parameters[1] = new SqlParameter("@Cantidad", detalle.Cantidad);
            parameters[2] = new SqlParameter("@PrecioUnitario", detalle.PrecioUnitario);

            return acceso.Escribir("P_RegistrarDetalleVenta", parameters);
        }
    }
}
