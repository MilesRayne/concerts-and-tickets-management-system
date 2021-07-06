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
    public partial class SavePerformer : UserControl
    {

        private SavePerformerController spc;
        public SavePerformer(SavePerformerController spc)
        {
            this.spc = spc;
            InitializeComponent();
        }

        private void SavePerformer_Load(object sender, EventArgs e)
        {
            cbGenre.DataSource = spc.GetGenres();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            spc.SavePerformer(tbArtistName, cbGenre);
        }
    }
}
