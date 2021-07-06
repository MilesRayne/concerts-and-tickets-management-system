using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.TicketSO
{
    public class BuyTicketSO : SystemOperationBase
    {

        public BuyTicketSO(User user)
        {
            this.user = user;
        }
        public Ticket Result { get; set; }
        private User user { get; set; }
        protected override void ExecuteOperation(IEntity entity, string queryColumn)
        {
            Concert c = (Concert)entity;
            Ticket t = new Ticket
            {
                Concert = c,
                User = this.user
            };
            repository.Save(t);
            int remainingSlots = c.RemainingSlots - 1;
            repository.Update(c, $"RemainingSlots = {remainingSlots}", c.ID);

            Result = t;

        }
    }
}
