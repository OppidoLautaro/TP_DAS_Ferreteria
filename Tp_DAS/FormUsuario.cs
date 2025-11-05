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

namespace Tp_DAS
{
    public partial class FormUsuario : Form
    {
        public FormUsuario(Usuario usuario)
        {
            InitializeComponent();
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            labelhor.Text = DateTime.Now.ToString("HH:mm");
            labelFec.Text = DateTime.Now.ToString("dd/MM/yyyy");

            timer1.Start();
            OcultarSubmenu();
        }


        private Form formActivo = null;
        private void AbrirformulariosHijos(Form formHijo)
        {
            if (formActivo != null)
            {
                formActivo.Close();

            }
            formActivo = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(formHijo);
            panelContenedor.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }

        private void OcultarSubmenu()
        {
            if (PanelSubMenú.Visible == true)
            {
                PanelSubMenú.Visible = false;
            }
        }

        private void MostrarSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                OcultarSubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelhor.Text = DateTime.Now.ToString("HH:mm");
            labelFec.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnmedia_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(PanelSubMenú);
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            AbrirformulariosHijos(new ProductosUser());
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
