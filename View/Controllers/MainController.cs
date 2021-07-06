using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View.UserControls;

namespace View.Controllers
{
    public class MainController
    {
        internal void openSearchPerformer(FrmMain frmMain)
        {
            frmMain.SetPanel(new SearchPerformer(new SearchPerformerController()));
        }

        internal void openLoginForm(FrmMain frmMain)
        {
            Communication.Communication.Instance.Disconnect();
            GUICoordinator.Instance.OpenLoginForm();
            frmMain.Dispose();
        }

        internal void openCreateConcert(FrmMain frmMain)
        {
            frmMain.SetPanel(new SaveConcert(new SaveConcertController()));
        }

        internal void openCreatePerformer(FrmMain frmMain)
        {
            frmMain.SetPanel(new SavePerformer(new SavePerformerController()));
        }

        internal void openSearchConcert(FrmMain frmMain)
        {
            frmMain.SetPanel(new SearchConcert(new SearchConcertController()));
        }

        internal void OpenProfile(FrmMain frmMain)
        {
            frmMain.SetPanel(new UserProfile(new ProfileController()));
        }

        internal User getUser()
        {
            return GUICoordinator.Instance.User;
        }
    }
}
