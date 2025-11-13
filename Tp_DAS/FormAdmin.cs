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
    public partial class FormAdmin : Form
    {
        private Usuario usuario;
        public FormAdmin(Usuario u)
        {
            InitializeComponent();
            perzonalizarDiseño();
            usuario = u;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();

            labelhora.Text = DateTime.Now.ToString("HH:mm");
            labelFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void perzonalizarDiseño()  
        { 
            PanelSubMenu.Visible = false;
        }

        private void OcultarSubmenu()
        {
            if (PanelSubMenu.Visible == true) 
            { 
                PanelSubMenu.Visible = false;
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

        private void btnMedia_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(PanelSubMenu);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirformulariosHijos(new Stock());
            //..
            OcultarSubmenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirformulariosHijos(new ResumenVentas());
            //..
            OcultarSubmenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //..
            OcultarSubmenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //..
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
            panelContenedor.Controls.Clear();
            panelContenedor.Controls.Add(formHijo);
            panelContenedor.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }

        private void labelhora_Click(object sender, EventArgs e)
        {

        }

        private void labelFecha_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            labelhora.Text = DateTime.Now.ToString("HH:mm");
            labelFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            BE.Sesion.GetInstance().SetUsuario(null);
            FormLogin login = new FormLogin();
            login.Show();

            this.Close();
            
        }
    }
}
