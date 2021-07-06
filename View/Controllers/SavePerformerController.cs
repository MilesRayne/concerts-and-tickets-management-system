using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Exceptions;
using View.Helpers;

namespace View.Controllers
{
    public class SavePerformerController
    {
        internal List<Genre> GetGenres()
        {
            return Communication.Communication.Instance.GetGenres();
        }

        internal void SavePerformer(TextBox tbArtistName, ComboBox cbGenre)
        {
            if (!UserControlHelpers.EmptyFieldValidation(tbArtistName)) return;

            Performer p = new Performer
            {
                ArtistName = tbArtistName.Text,
                Genre = (Genre)cbGenre.SelectedItem
            };

            try
            {
                Performer result = Communication.Communication.Instance.SavePerformer(p);
                //!SK4 - 5
                MessageBox.Show($"Uspešno ste sačuvali izvođača!");
            }
            catch (SystemOperationException e)
            {

                MessageBox.Show(e.Message);
            }
        }
    }
}
