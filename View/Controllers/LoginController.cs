using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Exceptions;
using View.Helpers;
using View.UserControls;

namespace View.Controllers
{
    public class LoginController
    {


        internal void Login(TextBox txtUsername, TextBox txtPassword, FrmLogin frmLogin)
        {

            //stop execution if validation fails
            if (!UserControlHelpers.EmptyFieldValidation(txtUsername) | !UserControlHelpers.EmptyFieldValidation(txtPassword)) return;

            try
            {
                User u = Communication.Communication.Instance.Login(txtUsername.Text, txtPassword.Text);
                GUICoordinator.Instance.User = u;
                //! SK2: Korak 5
                MessageBox.Show("Uspešno ste se prijavili na korisnički nalog!");
                GUICoordinator.Instance.OpenMainForm();
                frmLogin.Dispose();


            } catch (SystemOperationException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        internal void Register(TextBox txtUsername, TextBox txtPassword, TextBox txtName, TextBox txtSurname, TextBox txtEmail, FrmLogin frmLogin)
        {
            //stop execution if validation fails
            if (!UserControlHelpers.EmptyFieldValidation(txtUsername) | !UserControlHelpers.EmptyFieldValidation(txtPassword)) return;

            try
            {
                User u = Communication.Communication.Instance.Register(txtUsername.Text, txtPassword.Text, txtName.Text, txtSurname.Text, txtEmail.Text);
                GUICoordinator.Instance.User = u;
                //!SK1 - 5
                MessageBox.Show("Uspešno ste se registrovali i prijavili na korisnički nalog!");
                GUICoordinator.Instance.OpenMainForm();
                frmLogin.Dispose();


            }
            catch (SystemOperationException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        internal void OpenRegisterUserControl(FrmLogin frmLogin)
        {
            frmLogin.SetPanel(new UserRegister(frmLogin));
        }

        internal void OpenLoginUserControl(FrmLogin frmLogin)
        {
            frmLogin.SetPanel(new UserLogin(frmLogin));
        }

        internal bool Connect()
        {
            try
            {
                Communication.Communication.Instance.Connect();
                return true;
            }
            catch (SocketException)
            {
                MessageBox.Show("Greska pri povezivanju sa serverom!");
                return false;
            }
        }
    }
}
