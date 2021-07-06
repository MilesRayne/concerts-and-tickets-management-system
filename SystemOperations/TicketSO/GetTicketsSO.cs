using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.TicketSO
{
    public class GetTicketsSO : SystemOperationBase
    {

        public List<TicketProfileDTO> Result { get; set; }
        protected override void ExecuteOperation(IEntity entity, string queryColumn)
        {
            User u = (User)entity;

            List<Ticket> allTickets = repository.GetAll(new Ticket()).Cast<Ticket>().ToList();
            List<Concert> allConcerts = repository.GetAll(new Concert()).Cast<Concert>().ToList();
            List<TicketProfileDTO> result = new List<TicketProfileDTO>(); 


            foreach(Concert c in allConcerts)
            {
                int num = 0;
                foreach(Ticket ticket in allTickets)
                {
                    if (ticket.User.ID == u.ID)
                    {
                        if (c.ID == ticket.Concert.ID)
                        {
                            num++;
                        }
                    }
                }

                if (num>0)
                {
                    TicketProfileDTO ticketProfileDTO = new TicketProfileDTO
                    {
                        Concert = c,
                        Address = c.Address,
                        Municipality = c.Address.Municipality,
                        numOfTickets = num
                    };

                    result.Add(ticketProfileDTO);
                }
            }

            Result = result;

        }
    }
}
