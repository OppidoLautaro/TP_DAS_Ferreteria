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
    public partial class Stock : Form
    {
        ProductoBLL productoBLL = new ProductoBLL();

        public Stock()
        {
            InitializeComponent();
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Label)
                    ctrl.ForeColor = Color.Black;

                if (ctrl is TextBox)
                {
                    ctrl.ForeColor = Color.Black;
                    ctrl.BackColor = Color.White;
                }

                if (ctrl is Button)
                {
                    ctrl.ForeColor = Color.Black;
                    ctrl.BackColor = Color.White;
                }
            }
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            Dgv();

        }

        public void Dgv()
        {
            dataGridViewStock.DataSource = productoBLL.ListarProductos();
            dataGridViewStock.ReadOnly = true;
            dataGridViewStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewStock.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewStock.DefaultCellStyle.BackColor = Color.White;
            dataGridViewStock.EnableHeadersVisualStyles = false;

            dataGridViewStock.DataSource = productoBLL.ListarProductos();
        }

        public void txts()
        {
            textBox1.Clear();
            textBox2.Clear();
            dataGridViewStock.DataSource = productoBLL.ListarProductos();
        }

        private void dataGridViewStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            productoBLL.AgregarStockProdu(Convert.ToInt32(textBox1.Text),Convert.ToInt32(textBox2.Text)); 
            txts();
        }
    }

    
}
