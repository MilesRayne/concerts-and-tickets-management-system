using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View.Controllers;

namespace View
{
    public class GUICoordinator
    {
        private LoginController loginController = new LoginController();
        private MainController mainController = new MainController();
        private FrmLogin frmLogin;
        private FrmMain frmMain;

        public User User { get; set; }

        private static GUICoordinator instance;

        private GUICoordinator() { }

        public static GUICoordinator Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GUICoordinator();
                }
                return instance;
            }
        }


        public void OpenLoginForm()
        {
            frmLogin = new FrmLogin(loginController);
            frmLogin.Show();
        }

        internal void OpenMainForm()
        {
                frmMain = new FrmMain(mainController);
                frmMain.Show();

        }
    }
}
