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
        ClienteBLL c = new ClienteBLL();
        decimal total = 0;

        private void ProductosUser_Load(object sender, EventArgs e)
        {
            RefrescarCarrito();

            ActualizarDGV();

            CargarClientes();

            List<ProduCarrito> carrito = new List<ProduCarrito>();
        }

        private void CargarClientes()
        {
            var lista = c.ListarClientes();

            cmbClientes.DataSource = lista;
            cmbClientes.DisplayMember = "ComboBox";  // lo que ve el usuario
            cmbClientes.ValueMember = "Id";  // lo que se usa internamente
        }

        public void LimpiarTextboxs()
        {
            txtIdProducto.Clear();
            
        }

        public void ActualizarDGV()
        {
            listaProductos = productoBLL.ListarProductos();
            dataGridView1.DataSource = listaProductos;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            // VALIDAR CANTIDAD (CON USER CONTROL)
            string cantidadTexto = userControl21.CantidadTexto;

            if (!userControl21.ValidaRegex(cantidadTexto))
            {
                MessageBox.Show("La cantidad debe ser un número válido.");
                return;
            }

            int cantidad = int.Parse(cantidadTexto);
            if (cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a 0.");
                return;
            }

            // VALIDAR ID PRODUCTO
            if (!int.TryParse(txtIdProducto.Text, out int id))
            {
                MessageBox.Show("ID inválido.");
                return;
            }

            var prod = listaProductos.FirstOrDefault(x => x.IdProducto == id);
            if (prod == null)
            {
                MessageBox.Show("Producto no encontrado.");
                return;
            }

            // AGREGAR A LA LISTA
            var item = new ProduCarrito
            {
                Producto = prod,
                Cantidad = cantidad
            };

            carrito.Add(item);
            total += item.Subtotal;

            RefrescarCarrito();
            LimpiarTextboxs();
        }


        private void RefrescarCarrito()
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


        private void btnCompra_Click(object sender, EventArgs e)
        {
            if (carrito.Count == 0)
            {
                MessageBox.Show("El carrito está vacío.");
                return;
            }

            Venta venta = new Venta
            {
                FechaVenta = DateTime.Now,
                IDCliente = Convert.ToInt32(cmbClientes.SelectedValue),
                MontoTotal = carrito.Sum(x => x.Subtotal)
            };

            List<DetalleVenta> detalles = carrito.Select(x => new DetalleVenta
            {
                    IDProducto = x.IDProducto,
                    Cantidad = x.Cantidad,
                    PrecioUnitario = x.PrecioUnitario
            }).ToList();

            try
            {
                int idVenta = ventasBLL.RegistrarVenta(venta, detalles);

                foreach (var item in carrito)
                {
                    ventasBLL.RestarStockProdu(item.IDProducto, item.Cantidad);
                }

                MessageBox.Show("Venta registrada correctamente. ID: " + idVenta);

                carrito.Clear();
                total = 0;

                RefrescarCarrito();
                LimpiarTextboxs();
                ActualizarDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar venta: " + ex.Message);
            }
        }
    }
    
}
