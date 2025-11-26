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
            if (listBoxCarrito.Items.Count == 0)
            {
                listBoxCarrito.Text = "Vacio";
            }

            ActualizarDGV();


            List<ProduCarrito> carrito = new List<ProduCarrito>();
        }

        public void LimpiarTextboxs()
        {
            txtIdProducto.Clear();
            txtCantidadProdu.Clear();
        }

        public void ActualizarDGV()
        {
            listaProductos = productoBLL.ListarProductos();
            dataGridView1.DataSource = listaProductos;
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
            listBoxCarrito.Items.Add(item);
            total += item.Subtotal;
            lblTotal.Text = $"${total}";
            LimpiarTextboxs();

        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta();
            venta.FechaVenta = DateTime.Now;
            venta.IDCliente = 1; // es para probar nada mas
            venta.MontoTotal = carrito.Sum(x => x.Subtotal);

            //
            List<DetalleVenta> detalles = carrito.Select(x => new DetalleVenta
            {
                IDProducto = x.IDProducto,
                Cantidad = x.Cantidad,
                PrecioUnitario = x.PrecioUnitario,
            }).ToList();
            //

            int idVenta = ventasBLL.RegistrarVenta(venta, detalles);

            MessageBox.Show("Venta registrada correctamente. Numero de Venta: " + idVenta);

            carrito.Clear();
            listBoxCarrito.Items.Clear();
            lblTotal.Text = "$0";
            LimpiarTextboxs();
            

            //

            int id = int.Parse(txtIdProducto.Text);
            int cantidad = int.Parse(txtCantidadProdu.Text);


            if (cantidad <= 0)
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

            ventasBLL.RestarStockProdu(id, cantidad );
            ActualizarDGV();
        }
    }
    
}
