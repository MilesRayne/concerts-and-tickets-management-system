using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.ConcertSO
{
    public class DeleteConcertSO : SystemOperationBase
    {
        public Concert Result { get; set; }
        protected override void ExecuteOperation(IEntity entity, string queryColumn)
        {
            Concert c = (Concert)entity;
            repository.Delete(c.ConcertPerformers[0], c.ID);
            repository.Delete(new Ticket(), c.ID);
            repository.Delete(c, c.ID);

            Result = c;
        }
    }
}
