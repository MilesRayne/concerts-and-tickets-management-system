using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Exceptions;

namespace View.Controllers
{
    public class ProfileController
    {
        internal List<TicketProfileDTO> GetTickets(User u)
        {
            try
            {
                return Communication.Communication.Instance.GetTickets(u);
            }
            catch (SystemOperationException)
            {
                MessageBox.Show("Sistem ne može da učita karte.");
            }

            return null;
        }

        internal User getUser()
        {
            return GUICoordinator.Instance.User;
        }
    }
}
