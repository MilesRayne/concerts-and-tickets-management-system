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
    public class SearchPerformerController
    {
        internal List<Performer> Search(TextBox tbQuery)
        {
            if (!UserControlHelpers.EmptyFieldValidation(tbQuery)) return null;

            try
            {
                return Communication.Communication.Instance.GetPerformersByQuery(tbQuery.Text);
            }
            catch (SystemOperationException)
            {

                MessageBox.Show("Sistem ne može da učita izvođače.");
            }

            return null;
        }

        internal List<Performer> GetPerformers()
        {
            try
            {
                return Communication.Communication.Instance.GetPerformers();
            }
            catch (SystemOperationException)
            {
                MessageBox.Show("Sistem ne može da učita izvođače.");
            }

            return null;
        }

        internal List<Concert> GetConcertsOfPerformer(Performer selectedPerformer)
        {
            try
            {
                return Communication.Communication.Instance.GetConcertsOfPerformer(selectedPerformer);
            }
            catch (SystemOperationException)
            {

                MessageBox.Show("Sistem ne može da učita koncerte izvođača.");
            }

            return null;
        }
    }
}
