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
    public partial class SaveConcert : UserControl
    {

        private SaveConcertController saveConcertController;
        private Concert concert;
        public SaveConcert(SaveConcertController scc)
        {
            this.saveConcertController = scc;
            InitializeComponent();
            concert = new Concert();
        }

        private void SaveConcert_Load(object sender, EventArgs e)
        {
            cbAddress.DataSource = saveConcertController.GetAddresses();
            cbPerformer.DataSource = saveConcertController.GetPerformers();
            btnRemovePerformer.Enabled = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cbAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            Address a = (Address)cbAddress.SelectedItem;
            tbCity.Text = $"{a.Municipality.ZIP}, {a.Municipality.City}";
            concert.Address = a;
        }

        private void btnAddPerformer_Click(object sender, EventArgs e)
        {
            Performer p = (Performer)cbPerformer.SelectedItem;
            dgvPerformers.DataSource = null;
            dgvPerformers.DataSource = saveConcertController.AddPerformer(p);
            resetPerformersTable();
            btnRemovePerformer.Enabled = true;

        }

        private void resetPerformersTable()
        {
            foreach (DataGridViewColumn column in dgvPerformers.Columns)
            {
                column.Visible = false;
            }
            dgvPerformers.Columns[1].HeaderText = "Naziv izvođača";
            dgvPerformers.Columns[1].Visible = true;
            dgvPerformers.Columns[2].HeaderText = "Žanr";
            dgvPerformers.Columns[2].Visible = true;
            dgvPerformers.Columns[2].Width = 150;
            dgvPerformers.Columns[1].Width = 150;
        }

        private void btnRemovePerformer_Click(object sender, EventArgs e)
        {
            Performer p = (Performer)dgvPerformers.SelectedRows[0].DataBoundItem;
            dgvPerformers.DataSource = null;
            dgvPerformers.DataSource = saveConcertController.RemovePerformer(p);
            resetPerformersTable();
            if (dgvPerformers.RowCount == 0)
            {
                btnRemovePerformer.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveConcertController.SaveConcert(tbConcertName, tbPrice, tbSlotNumber, tbStreetNumber, cbAddress, dtpDatetime);
        }
    }
}
