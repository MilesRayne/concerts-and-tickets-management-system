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

namespace View.UserControls
{
    public partial class UserProfile : UserControl
    {
        private ProfileController pc;
        public UserProfile(ProfileController pc)
        {
            this.pc = pc;
            InitializeComponent();
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            User u = pc.getUser();
            tbName.Text = u.Name;
            tbSurname.Text = u.Surname;
            tbEmail.Text = u.Email;

            dgvTickets.DataSource = null;
            dgvTickets.DataSource = pc.GetTickets(u);

            dgvTickets.Columns[0].HeaderText = "Koncert";
            dgvTickets.Columns[0].Width = 300;

            dgvTickets.Columns[1].HeaderText = "Br. karata";
            dgvTickets.Columns[1].Width = 100;

            dgvTickets.Columns[2].HeaderText = "Adresa";
            dgvTickets.Columns[2].Width = 250;

            dgvTickets.Columns[3].HeaderText = "Grad";
            dgvTickets.Columns[3].Width = 100;

        }
    }
}
