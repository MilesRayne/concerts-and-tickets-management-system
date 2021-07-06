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

namespace View.UserControls
{
    public partial class SearchConcert : UserControl
    {
        private SearchConcertController scc;
        public SearchConcert(SearchConcertController scc)
        {
            this.scc = scc;
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dgvPerformers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvFoundConcerts.DataSource = null;
            List<Concert> concerts = scc.Search(tbQuery);

            if (concerts == null) return;

            else if (concerts.Count > 0)
            {
                dgvFoundConcerts.DataSource = concerts;
                resetConcertsTable();

                //TODO Proveri dokumentaciju
                MessageBox.Show("Sistem je našao koncerte po zadatoj vrednosti.");
            } else
            {
                MessageBox.Show("Sistem ne mоže da nađe koncert sa datim nazivom.");
            }
        }

        private void resetConcertsTable()
        {
            foreach (DataGridViewColumn column in dgvFoundConcerts.Columns)
            {
                column.Visible = false;
            }
            dgvFoundConcerts.Columns[1].HeaderText = "Naziv";
            dgvFoundConcerts.Columns[1].Visible = true;
            dgvFoundConcerts.Columns[1].Width = 150;
            dgvFoundConcerts.Columns[3].HeaderText = "Adresa";
            dgvFoundConcerts.Columns[3].Visible = true;
            dgvFoundConcerts.Columns[3].Width = 150;
            dgvFoundConcerts.Columns[4].HeaderText = "Broj ulice";
            dgvFoundConcerts.Columns[4].Visible = true;
            dgvFoundConcerts.Columns[4].Width = 50;
        }

        private void resetPerformersTable()
        {
            foreach (DataGridViewColumn column in dgvPerformers.Columns)
            {
                column.Visible = false;
            }
            dgvPerformers.Columns[1].HeaderText = "Naziv izvođača";
            dgvPerformers.Columns[1].Visible = true;
            dgvPerformers.Columns[1].Width = 150;
            dgvPerformers.Columns[2].HeaderText = "Žanr";
            dgvPerformers.Columns[2].Visible = true;
            dgvPerformers.Columns[2].Width = 150;
        }

        private void SearchConcert_Load(object sender, EventArgs e)
        {
            List<Concert> concerts = scc.GetConcerts();
            dgvFoundConcerts.DataSource = null;
            dgvFoundConcerts.DataSource = concerts;
            resetConcertsTable();

            cbPerformers.DataSource = scc.GetPerformers();

            checkIfAdmin();
        }

        private void checkIfAdmin()
        {
            User u = scc.getUser();
            if (u.isAdmin)
            {
                lblPerformer.Visible = true;
                cbPerformers.Visible = true;
                btnAddPerformer.Visible = true;
                btnRemovePerformer.Visible = true;
                btnSave.Visible = true;
                btnDelete.Visible = true;
                tbName.ReadOnly = false;
                tbPrice.ReadOnly = false;
                tbRemainingSlots.ReadOnly = false;
                tbTotalSlots.ReadOnly = false;
                tbPrice.ReadOnly = false;
            } else
            {
                btnAddPerformer.Visible = false;
                btnRemovePerformer.Visible = false;
                btnSave.Visible = false;
                btnDelete.Visible = false;
                lblPerformer.Visible = false;
                cbPerformers.Visible = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            List<Concert> concerts = scc.GetConcerts();
            dgvFoundConcerts.DataSource = null;
            dgvFoundConcerts.DataSource = concerts;
            resetConcertsTable();
            tbQuery.Text = "";
        }

        private void dgvFoundConcerts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvFoundConcerts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFoundConcerts.SelectedRows.Count > 0)
            {
                Concert c = (Concert)dgvFoundConcerts.SelectedRows[0].DataBoundItem;
                tbName.Text = c.Name;
                tbDate.Text = c.Time;
                tbPrice.Text = c.TicketPrice.ToString();
                tbTotalSlots.Text = c.TotalSlots.ToString();
                tbRemainingSlots.Text = c.RemainingSlots.ToString();
                tbAddress.Text = $"{c.Address.Name} {c.StreetNumber}, {c.Address.Municipality.Name}, {c.Address.Municipality.City}";

                dgvPerformers.DataSource = null;
                dgvPerformers.DataSource = scc.GetPerformersOfConcert(c);
                resetPerformersTable();

                scc.selectConcert(c, (List<Performer>)dgvPerformers.DataSource);
                btnRemovePerformer.Enabled = true;
            }
        }

        private void btnAddPerformer_Click(object sender, EventArgs e)
        {
            Performer p = (Performer)cbPerformers.SelectedItem;
            dgvPerformers.DataSource = null;
            dgvPerformers.DataSource = scc.AddPerformer(p);
            resetPerformersTable();
            btnRemovePerformer.Enabled = true;
        }

        private void btnRemovePerformer_Click(object sender, EventArgs e)
        {
            Performer p = (Performer)dgvPerformers.SelectedRows[0].DataBoundItem;
            dgvPerformers.DataSource = null;
            dgvPerformers.DataSource = scc.RemovePerformer(p);
            resetPerformersTable();
            if (dgvPerformers.RowCount == 0)
            {
                btnRemovePerformer.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            scc.SaveConcert(tbName, tbPrice, tbTotalSlots, tbRemainingSlots);
            List<Concert> concerts = scc.GetConcerts();
            dgvFoundConcerts.DataSource = null;
            dgvFoundConcerts.DataSource = concerts;
            if (concerts.Count == 0)
            {
                dgvPerformers.DataSource = null;
            }
            resetConcertsTable();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            scc.DeleteConcert();
            List<Concert> concerts = scc.GetConcerts();
            dgvFoundConcerts.DataSource = null;
            dgvFoundConcerts.DataSource = concerts;
            if (concerts.Count == 0)
            {
                dgvPerformers.DataSource = null;
            }
            resetConcertsTable();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            scc.BuyTicket();
            List<Concert> concerts = scc.GetConcerts();
            dgvFoundConcerts.DataSource = null;
            dgvFoundConcerts.DataSource = concerts;
            if (concerts.Count == 0)
            {
                dgvPerformers.DataSource = null;
            }
            resetConcertsTable();
        }
    }
}
