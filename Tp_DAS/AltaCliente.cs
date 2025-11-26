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
            string emailIngresado = userControl11.Email;

            if (!userControl11.ValidaRegex(emailIngresado))
            {
                MessageBox.Show("El email no tiene un formato válido. Debe ser del tipo nombre@mail.com");
                return; 
            }
            
            MessageBox.Show("Email correcto, continuando...");

            
            BE.Cliente cliente = new BE.Cliente();
            //NO HAY QUE CREAR ASI EL CLIENTE BE.Cliente cliente = new BE.Cliente();
            //BE.Cliente cliente = new BE.Cliente(CONSTRUCTOR);
            cliente.Nombre = txtNombreCliente.Text;
            cliente.Apellido = txtApellidoCliente.Text;
            cliente.DNI = txtbDNI.Text;
            cliente.Email = emailIngresado;
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
            txtbTelefono.Clear();
            txtbDireccion.Clear();
            }
    
    }
}
