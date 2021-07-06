using Domain;
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
    public partial class FrmMain : Form
    {

        private readonly MainController mainController;
        public FrmMain(MainController mainController)
        {
            InitializeComponent();
            this.mainController = mainController;
        }
        
        internal void SetPanel(UserControl userControl)
        {
            pnlContainer.Controls.Clear();
            userControl.Parent = pnlContainer;
            userControl.Dock = DockStyle.Fill;
        }

        private void pretragaIzvođačaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.openSearchPerformer(this);
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainController.openLoginForm(this);
        }

        private void kreiranjeKoncertaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.openCreateConcert(this);
        }

        private void kreiranjeIzvođačaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.openCreatePerformer(this);
        }

        private void pretragaKoncerataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.openSearchConcert(this);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

            User u = mainController.getUser();
            if (!u.isAdmin)
            {
                menuCreateConcert.Visible = false;
                menuCreatePerformer.Visible = false;
            }
            mainController.OpenProfile(this);
        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenProfile(this);
        }
    }
}
