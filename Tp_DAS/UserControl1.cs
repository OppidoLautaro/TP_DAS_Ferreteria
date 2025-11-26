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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
        private string email;

        public string Email
        {
            get { return txtbEmail.Text; }
            set { email = txtbEmail.Text; }
        }
        public bool ValidaRegex(string numTelefono)
        {
            var regex = new Regex(@"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.com$");
            txtbEmail.Clear();

            return regex.IsMatch(numTelefono);
        }


        

    }

}
