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
    public class MP_Producto
    {
        Acceso acceso = new Acceso();

        public int AgregarStockProdu(int idProducto, int stock)
        {
            Producto producto = new Producto();

            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@IDProducto", idProducto);
            sqlParameters[1] = new SqlParameter("@Stock", stock);

            int fa = acceso.Escribir("StockProducto",sqlParameters);

            return fa;
        }

        public List<BE.Producto> ListarProductos()
        {
            List<BE.Producto> lista = new List<BE.Producto>();
            DataTable tabla = acceso.Leer("ListarProductos", null);

            foreach (DataRow dr in tabla.Rows)
            {
                BE.Producto prod = new BE.Producto();
                prod.IdProducto = Convert.ToInt32(dr["IDProducto"]);
                prod.Nombre = dr["Nombre"].ToString();
                prod.Descripcion = dr["Descripcion"].ToString();
                prod.Precio = Convert.ToDecimal(dr["Precio"]);
                prod.Stock = Convert.ToInt32(dr["Stock"]);

                lista.Add(prod);
            }

            return lista;
        }

        public int RestarStockProdu(int idProducto, int stock)
        {
            Producto producto = new Producto();

            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@IDProducto", idProducto);
            sqlParameters[1] = new SqlParameter("@Stock", stock);

            int fa = acceso.Escribir("RestarStockProducto", sqlParameters);

            return fa;
        }

    }
}
