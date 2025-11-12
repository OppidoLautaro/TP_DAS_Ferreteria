using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;

namespace Tp_DAS
{
    public partial class AltaCliente : Form
    {
        public AltaCliente()
        {
            InitializeComponent();
        }
        ClienteBLL clienteBLL = new ClienteBLL();

        private void AltaCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            BE.Cliente cliente = new BE.Cliente();

            cliente.Nombre = txtNombreCliente.Text;
            cliente.Apellido = txtApellidoCliente.Text;
            cliente.DNI = txtbDNI.Text;
            cliente.Email = txtbEmail.Text;
            cliente.Telefono = txtbTelefono.Text;
            cliente.Direccion = txtbDireccion.Text;


            int fa = clienteBLL.AgregarCliente(cliente);

            if (fa > 0)
            {
                MessageBox.Show("Cliente agregado correctamente");
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("No se pudo agregar el cliente");
            }
        }
            private void LimpiarCampos()
            {
            txtNombreCliente.Clear();
            txtApellidoCliente.Clear();
            txtbDNI.Clear();
            txtbEmail.Clear();
            txtbTelefono.Clear();
            txtbDireccion.Clear();
            }
    
    }
}
