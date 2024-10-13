using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C1_UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void PictureBoxLoginLogo_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresarLogin_Click(object sender, EventArgs e)
        {
            if (txt_login.Text == "123")
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.No;
            }
            Hide();

        }

        private void btnCancelarLogin_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Hide();
        }
    }
}
