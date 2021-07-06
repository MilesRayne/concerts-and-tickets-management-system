using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class TicketProfileDTO
    {
        public Concert Concert { get; set; }
        public int numOfTickets { get; set; }

        public Address Address { get; set; }

        public Municipality Municipality { get; set; }
    }
}
