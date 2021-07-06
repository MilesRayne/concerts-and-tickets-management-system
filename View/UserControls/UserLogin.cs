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
    public partial class UserLogin : UserControl
    {

        private FrmLogin frmLogin;
        public UserLogin(FrmLogin frmLogin)
        {
            this.frmLogin = frmLogin;
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            {

                if (frmLogin.loginController.Connect())
                    frmLogin.loginController.Login(txtUsername, txtPassword, frmLogin);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin.loginController.OpenRegisterUserControl(frmLogin);
        }
    }
}
