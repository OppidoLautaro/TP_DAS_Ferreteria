using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp_DAS
{
    public partial class ProductosUser : Form
    {
        public ProductosUser()
        {
            InitializeComponent();
        }

        ProductoBLL productoBLL = new ProductoBLL();
        VentasBLL ventasBLL = new VentasBLL();
        List<BE.Producto> listaProductos = new List<BE.Producto>();
        List<ProduCarrito> carrito = new List<ProduCarrito>();
        decimal total = 0;


        private void ProductosUser_Load(object sender, EventArgs e)
        {
            ActualizarDGV();
            RefreshCarritoListBox();
        }

        public void ActualizarDGV()
        {
            listaProductos = productoBLL.ListarProductos();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaProductos;
        }

        private void RefreshCarritoListBox()
        {
            listBoxCarrito.Items.Clear();
            if (carrito == null || carrito.Count == 0)
            {
                listBoxCarrito.Items.Add("Vacio");
                lblTotal.Text = "$0";
                return;
            }

            foreach (var item in carrito)
            {
                string productoNombre = item.Producto != null ? (item.Producto.Nombre ?? $"ID:{item.IDProducto}") : $"ID:{item.IDProducto}";
                string line = $"{productoNombre} Cant: {item.Cantidad} Sub: {item.Subtotal:C}";
                listBoxCarrito.Items.Add(line);
            }

            lblTotal.Text = $"{total:C}";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdProducto.Text, out int id))
            {
                MessageBox.Show("ID inválido.");
                return;
            }

            if (!int.TryParse(txtCantidadProdu.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Cantidad inválida.");
                return;
            }

            var prod = listaProductos.FirstOrDefault(p => p.IdProducto == id);
            if (prod == null)
            {
                MessageBox.Show("Producto no encontrado.");
                return;
            }

            var item = new ProduCarrito { Producto = prod, Cantidad = cantidad };
            carrito.Add(item);
            total += item.Subtotal;
<<<<<<< Updated upstream
            lblTotal.Text = $"${total}";

=======
            RefreshCarritoListBox();
            LimpiarTextboxs();
>>>>>>> Stashed changes
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            if (carrito == null || carrito.Count == 0)
            {
                MessageBox.Show("El carrito está vacío. Agregue productos antes de realizar la compra.");
                return;
            }

            Venta venta = new Venta
            {
                FechaVenta = DateTime.Now,
                IDCliente = 1,
                MontoTotal = carrito.Sum(x => x.Subtotal)
            };

            List<DetalleVenta> detalles = carrito.Select(x => new DetalleVenta
            {
                IDProducto = x.IDProducto,
                Cantidad = x.Cantidad,
                PrecioUnitario = x.PrecioUnitario
            }).ToList();

<<<<<<< Updated upstream
            int idVenta = ventasBLL.RegistrarVenta(venta, detalles);

            MessageBox.Show("Venta registrada correctamente. ID Venta: " + idVenta);

            carrito.Clear();
            listBoxCarrito.Items.Clear();
            lblTotal.Text = "$0";
            ActualizarDGV();

            //
            if (!int.TryParse(txtIdProducto.Text, out int id))
            {
                MessageBox.Show("ID inválido.");
                return;
            }

            if (!int.TryParse(txtCantidadProdu.Text, out int cantidad) || cantidad <= 0)
=======
            try
>>>>>>> Stashed changes
            {
                int idVenta = ventasBLL.RegistrarVenta(venta, detalles);

                foreach (var produ in carrito)
                {
                    ventasBLL.RestarStockProdu(produ.IDProducto, produ.Cantidad);
                }

                MessageBox.Show("Venta registrada correctamente.");
                
                carrito.Clear();
                total = 0;
                RefreshCarritoListBox();
                LimpiarTextboxs();
                ActualizarDGV();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Error al registrar la venta: " + ex.Message);
            }
<<<<<<< Updated upstream


            var item = new ProduCarrito { Producto = prod, Cantidad = cantidad };
            ventasBLL.RestarStockProdu(id,cantidad );
=======
>>>>>>> Stashed changes
        }
    }

}
