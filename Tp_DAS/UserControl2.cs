using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp_DAS
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

        }

        public bool ValidaRegex(string cantidad)
        {
            var regex = new Regex(@"^[0-9]+$");
            txtCantidadProdu.Clear();

            return regex.IsMatch(cantidad);
        }

        public string CantidadTexto
        {
            get { return txtCantidadProdu.Text; }
        }

        
        public int Cantidad
        {
            get
            {
                int.TryParse(txtCantidadProdu.Text, out int c);
                return c;
            }
        }
    }
}
