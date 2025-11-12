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
    public partial class Form4 : Form
    {
        UsuarioBLL usuarioBLL = new UsuarioBLL();
        public Form4()
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
                    Form1 f = new Form1(usuario);
                    f.Show();
                }
                else
                {
                    FormUsuario Fvendedor = new FormUsuario(usuario);
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
