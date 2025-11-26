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
    public partial class ResumenVentas : Form
    {
        public ResumenVentas()
        {
            InitializeComponent();
        }

        VentasBLL ventasBLL = new VentasBLL();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ResumenVentas_Load(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DataSource = ventasBLL.listarVentas() ;
        }
    }
}
