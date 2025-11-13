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
    public partial class FormLogin : Form
    {
        UsuarioBLL usuarioBLL = new UsuarioBLL();
        public FormLogin()
        {
            InitializeComponent();
        }
       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string User = textBox1.Text;
            string pass = textBox2.Text;

            Usuario usuario = usuarioBLL.Login(User, pass);

            if (usuario != null)
            {
                BE.Sesion.GetInstance().SetUsuario(usuario);

                MessageBox.Show("Bienvenido " + usuario.Username);

                if (usuario.Rol.NombreRol == "Admin")
                {
                    FormAdmin f = new FormAdmin(usuario);
                    f.Show();
                }
                else
                {
                    FormVendedor Fvendedor = new FormVendedor(usuario);
                    Fvendedor.Show();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrectos");
            }

        }

        private void Form4_Load(object sender, EventArgs e)
        {
           
        }
    }
}
