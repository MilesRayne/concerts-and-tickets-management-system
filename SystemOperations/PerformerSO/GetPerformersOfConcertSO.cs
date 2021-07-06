using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.PerformerSO
{
    public class GetPerformersOfConcertSO : SystemOperationBase
    {

        public List<Performer> Result { get; set; }
        protected override void ExecuteOperation(IEntity entity, string queryColumn)
        {
            Concert c = (Concert)entity;

            List<ConcertPerformer> cps = repository.GetAll(new ConcertPerformer()).Cast<ConcertPerformer>().ToList();

            List<Performer> performers = new List<Performer>();

            foreach (ConcertPerformer cp in cps)
            {
                if (cp.Concert.ID == c.ID)
                {
                    performers.Add(cp.Performer);
                }
            }

            Result = performers;
        }
    }
}
