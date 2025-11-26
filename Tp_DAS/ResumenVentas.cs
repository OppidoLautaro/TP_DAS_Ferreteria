using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Tp_DAS
{
    public partial class ResumenVentas : Form
    {

        VentasBLL ventas = new VentasBLL();


        public ResumenVentas()
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

        VentasBLL ventasBLL = new VentasBLL();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ResumenVentas_Load(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DataSource = ventasBLL.listarVentas() ;
        }


        


        private void btnCrearXml_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int idventa))
            {
                MessageBox.Show("Ingrese un número de venta válido.");
                return;
            }

            try
            {
                ventasBLL.GenerarXMLVenta(Convert.ToInt32(textBox1.Text));
                MessageBox.Show("XML generado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
