using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.UserControls
{
    public partial class UserRegister : UserControl
    {

        private FrmLogin frmLogin;
        public UserRegister(FrmLogin frmLogin)
        {
            this.frmLogin = frmLogin;
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin.loginController.OpenLoginUserControl(frmLogin);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            {

                if (frmLogin.loginController.Connect())
                    frmLogin.loginController.Register(txtUsername, txtPassword, txtName, txtSurname, txtEmail, frmLogin);
            }
        }
    }
}
