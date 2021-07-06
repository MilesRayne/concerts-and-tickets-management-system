using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Exceptions;
using View.Helpers;

namespace View.UserControls
{
    public class SearchConcertController
    {

        private Concert concert;

        public SearchConcertController()
        {
            concert = new Concert();
            concert.ConcertPerformers = new List<ConcertPerformer>();
        }
        internal List<Concert> Search(TextBox tbQuery)
        {
            if (!UserControlHelpers.EmptyFieldValidation(tbQuery)) return null;

            try
            {
                return Communication.Communication.Instance.GetConcertsByQuery(tbQuery.Text);
            }
            catch (SystemOperationException)
            {

                MessageBox.Show("Sistem ne može da učita koncerte.");
            }

            return null;
        }

        internal List<Concert> GetConcerts()
        {
            try
            {
                return Communication.Communication.Instance.GetConcerts();
            }
            catch (SystemOperationException)
            {

                MessageBox.Show("Sistem ne mоže da učita koncerte.");
            }

            return null;
        }

        internal List<Performer> GetPerformersOfConcert(Concert c)
        {
            try
            {
                return Communication.Communication.Instance.GetPerformersOfConcert(c);
            }
            catch (SystemOperationException)
            {

                MessageBox.Show("Sistem ne može da učita izvođače koncerta.");
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

        internal List<Performer> AddPerformer(Performer p)
        {
            List<Performer> performers = new List<Performer>();
            bool added = false;

            foreach (ConcertPerformer cp in concert.ConcertPerformers)
            {
                if (cp.Performer.ArtistName == p.ArtistName)
                {
                    MessageBox.Show("Izabrani izvođač je već dodat.");
                    added = true;
                }
                performers.Add(cp.Performer);
            }

            if (!added)
            {
                ConcertPerformer cp = new ConcertPerformer
                {
                    Concert = concert,
                    Performer = p
                };
                concert.ConcertPerformers.Add(cp);
                performers.Add(p);
            }

            return performers;
        }

        internal void selectConcert(Concert c, List<Performer> performers)
        {
            concert = c;
            c.ConcertPerformers = new List<ConcertPerformer>();
            foreach (Performer p in performers)
            {
                ConcertPerformer cp = new ConcertPerformer
                {
                    Concert = c,
                    Performer = p
                };
                
                c.ConcertPerformers.Add(cp);
            }
        }

        internal User getUser()
        {
            return GUICoordinator.Instance.User;
        }

        internal List<Performer> RemovePerformer(Performer p)
        {
            List<Performer> performers = new List<Performer>();
            ConcertPerformer cpToRemove = new ConcertPerformer();

            foreach (ConcertPerformer cp in concert.ConcertPerformers)
            {
                if (cp.Performer.ArtistName == p.ArtistName)
                {
                    cpToRemove = cp;
                }
                else
                {
                    performers.Add(cp.Performer);
                }
            }

            if (concert.ConcertPerformers.Contains(cpToRemove)) concert.ConcertPerformers.Remove(cpToRemove);
            else MessageBox.Show("Ovaj izvođač nije u listi.");

            return performers;
        }

        internal void SaveConcert(TextBox tbConcertName, TextBox tbPrice, TextBox tbTotalSlots, TextBox tbRemainingSlots)
        {
            if (!UserControlHelpers.EmptyFieldValidation(tbConcertName) |
                !UserControlHelpers.EmptyFieldValidation(tbPrice) |
                !UserControlHelpers.EmptyFieldValidation(tbTotalSlots) |
                !UserControlHelpers.EmptyFieldValidation(tbRemainingSlots)) return;

            if (concert.ConcertPerformers.Count < 1)
            {
                MessageBox.Show("Niste dodali izvođača.");
                return;
            }

            if (!UserControlHelpers.IntValidation(tbPrice) | !UserControlHelpers.IntValidation(tbTotalSlots)
                | !UserControlHelpers.IntValidation(tbRemainingSlots)) return;

            try
            {
                concert.Name = tbConcertName.Text;
                concert.TicketPrice = int.Parse(tbPrice.Text);
                concert.TotalSlots = int.Parse(tbTotalSlots.Text);
                concert.RemainingSlots = int.Parse(tbRemainingSlots.Text);

                Concert c = Communication.Communication.Instance.UpdateConcert(concert);
                //! SK7 - 13
                MessageBox.Show($"Uspešno ste izmenili koncert!");
            }
            catch (SystemOperationException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        internal void DeleteConcert()
        {
            try
            {
                Concert result = Communication.Communication.Instance.DeleteConcert(concert);
                MessageBox.Show($"Uspešno ste izbrisali koncert!");
            }
            catch (SystemOperationException e)
            {

                MessageBox.Show(e.Message);
            }
        }

        internal void BuyTicket()
        {

            if (concert.RemainingSlots < 1)
            {
                MessageBox.Show($"Ovaj koncert nema više slobodnih mesta");
                return;
            }

            try
            {
                Ticket result = Communication.Communication.Instance.BuyTicket(concert);
                MessageBox.Show($"Uspešno ste kupili kartu za odabrani koncert!");
            }
            catch (SystemOperationException e)
            {

                MessageBox.Show(e.Message);
            }
        }
    }
}
