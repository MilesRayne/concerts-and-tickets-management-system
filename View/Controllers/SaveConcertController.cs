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
    public class SaveConcertController
    {

        private Concert concert;

        public SaveConcertController()
        {
            concert = new Concert();
            concert.ConcertPerformers = new List<ConcertPerformer>();
        }

        internal List<Address> GetAddresses()
        {
            try
            {
                return Communication.Communication.Instance.GetAddresses();
            }
            catch (SystemOperationException)
            {
                MessageBox.Show("Sistem ne može da učita adrese.");
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

            foreach(ConcertPerformer cp in concert.ConcertPerformers)
            {
                if (cp.Performer.ArtistName == p.ArtistName)
                {
                    MessageBox.Show("Izabrani izvođač je već dodat.");
                    added = true;
                }
                performers.Add(cp.Performer);
            }

            if(!added)
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
            else  MessageBox.Show("Ovaj izvođač nije u listi.");

            return performers;
        }

        internal void SaveConcert(TextBox tbConcertName, TextBox tbPrice, TextBox tbSlotNumber, TextBox tbStreetNumber, ComboBox cbAddress, DateTimePicker dtpDatetime)
        {
            if (!UserControlHelpers.EmptyFieldValidation(tbConcertName) | 
                !UserControlHelpers.EmptyFieldValidation(tbPrice) | 
                !UserControlHelpers.EmptyFieldValidation(tbSlotNumber) |
                !UserControlHelpers.EmptyFieldValidation(tbStreetNumber)) return;

            if (concert.ConcertPerformers.Count < 1)
            {
                MessageBox.Show("Niste dodali izvođača.");
                return;
            }

            if (!UserControlHelpers.IntValidation(tbPrice) | !UserControlHelpers.IntValidation(tbSlotNumber)) return;

            try
            {
                concert.Name = tbConcertName.Text;
                concert.TicketPrice = int.Parse(tbPrice.Text);
                concert.TotalSlots = int.Parse(tbSlotNumber.Text);
                concert.RemainingSlots = int.Parse(tbSlotNumber.Text);
                concert.StreetNumber = tbStreetNumber.Text;
                concert.Time = dtpDatetime.Value.Date.ToString("d");
                concert.Address = (Address)cbAddress.SelectedItem;

                Concert c = Communication.Communication.Instance.SaveConcert(concert);
                //!SK3 - 5
                MessageBox.Show($"Uspešno ste kreirali koncert!");
            }
            catch (SystemOperationException e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
