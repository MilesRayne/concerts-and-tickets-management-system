using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Controllers;

namespace View
{
    public partial class FrmLogin : Form
        
    {
        internal LoginController loginController;
        public FrmLogin()
        {
            InitializeComponent();
        }

        public FrmLogin(LoginController loginController)
            {
                this.loginController = loginController;
                InitializeComponent();
            } 

        private void FrmLogin_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        internal void SetPanel(UserControl userControl)
        {
            pnlContainer.Controls.Clear();
            userControl.Parent = pnlContainer;
            userControl.Dock = DockStyle.Fill;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            loginController.OpenLoginUserControl(this);
        }
    }
}
