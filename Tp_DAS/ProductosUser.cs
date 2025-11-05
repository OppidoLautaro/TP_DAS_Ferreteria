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

        private void ProductosUser_Load(object sender, EventArgs e)
        {
            if(listBoxCarrito.Items.Count == 0)
            {
                listBoxCarrito.Text="Vacio";
            }

            dataGridView1.DataSource = productoBLL.ListarProductos();
        }



    }
}
