using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.ConcertSO
{
    public class UpdateConcertSO : SystemOperationBase
    {

        public Concert Result { get; set; }
        protected override void ExecuteOperation(IEntity entity, string queryColumn)
        {
            Concert c = (Concert)entity;
            repository.Update(c, $"Name = '{c.Name}', TicketPrice = {c.TicketPrice}, TotalSlots = {c.TotalSlots}, RemainingSlots = {c.RemainingSlots}", c.ID);
            repository.Delete(new ConcertPerformer(), c.ID);

            foreach(ConcertPerformer cp in c.ConcertPerformers)
            {
                cp.Concert.ID = c.ID;
                repository.Save(cp);
            }        
            Result = c;
        }
    }
}
