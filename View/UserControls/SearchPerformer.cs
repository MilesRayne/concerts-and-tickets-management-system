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
    public partial class SearchPerformer : UserControl
    {

        private SearchPerformerController spController;
        public SearchPerformer(SearchPerformerController spController)
        {
            this.spController = spController;
            InitializeComponent();
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvFoundPerformers.DataSource = null;
            List<Performer> performers = spController.Search(tbQuery);

            if (performers == null) return;

            else if (performers.Count > 0)
            {
                dgvFoundPerformers.DataSource = performers;
                resetFoundPerformersTable();

                //!SK6 - 4
                MessageBox.Show("Sistem je našao izvođače po zadatoj vrednosti.");
            } else
            {
                MessageBox.Show("Sistem ne može da nađe izvođača sa datim nazivom.");
            }
        }

        private void SearchPerformer_Load(object sender, EventArgs e)
        {
            List<Performer> performers = spController.GetPerformers();
            dgvFoundPerformers.DataSource = null;
            dgvFoundPerformers.DataSource = performers;
            resetFoundPerformersTable();
        }

        private void resetFoundPerformersTable()
        {
            foreach (DataGridViewColumn column in dgvFoundPerformers.Columns)
            {
                column.Visible = false;
            }
            dgvFoundPerformers.Columns[1].HeaderText = "Naziv izvođača";
            dgvFoundPerformers.Columns[1].Visible = true;
            dgvFoundPerformers.Columns[1].Width = 150;
            dgvFoundPerformers.Columns[2].HeaderText = "Žanr";
            dgvFoundPerformers.Columns[2].Visible = true;
            dgvFoundPerformers.Columns[2].Width = 150;
        }

        private void dgvFoundPerformers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFoundPerformers.SelectedRows.Count > 0) {
                Performer selectedPerformer = (Performer)dgvFoundPerformers.SelectedRows[0].DataBoundItem;
                tbArtistName.Text = selectedPerformer.ArtistName;
                tbGenre.Text = selectedPerformer.Genre.Name;
                dgvConcerts.DataSource = null;
                dgvConcerts.DataSource = spController.GetConcertsOfPerformer(selectedPerformer);
                resetConcertsTable();
            }

        }

        private void resetConcertsTable()
        {
            foreach (DataGridViewColumn column in dgvConcerts.Columns)
            {
                column.Visible = false;
            }
            dgvConcerts.Columns[1].HeaderText = "Naziv";
            dgvConcerts.Columns[1].Visible = true;
            dgvConcerts.Columns[1].Width = 150;
            dgvConcerts.Columns[3].HeaderText = "Adresa";
            dgvConcerts.Columns[3].Visible = true;
            dgvConcerts.Columns[3].Width = 150;
            dgvConcerts.Columns[4].HeaderText = "Broj ulice";
            dgvConcerts.Columns[4].Visible = true;
            dgvConcerts.Columns[4].Width = 50;
        }

        private void dgvFoundPerformers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbQuery_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gbSelectedPerformer_Enter(object sender, EventArgs e)
        {

        }

        private void dgvConcerts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tbGenre_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbArtistName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            List<Performer> performers = spController.GetPerformers();
            dgvFoundPerformers.DataSource = null;
            dgvFoundPerformers.DataSource = performers;
            resetFoundPerformersTable();
            tbQuery.Text = "";
        }
    }
}
