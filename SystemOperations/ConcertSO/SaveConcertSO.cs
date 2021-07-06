using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.ConcertSO
{
    
    public class SaveConcertSO : SystemOperationBase
    {
        public Concert Result { get; set; }
        protected override void ExecuteOperation(IEntity entity, string queryColumn)
        {
            Concert c = (Concert)entity;
            int newId = repository.GetNewId(c);
            c.ID = newId;
            repository.Save(c);

            foreach (ConcertPerformer cp in c.ConcertPerformers)
            {
                cp.Concert.ID = newId;
                repository.Save(cp);
            }

            Result = c;
        }
    }
}
