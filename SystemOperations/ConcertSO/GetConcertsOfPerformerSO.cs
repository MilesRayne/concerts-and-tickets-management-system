using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemOperations.ConcertSO
{
    public class GetConcertsOfPerformerSO : SystemOperationBase
    {

        public List<Concert> Result { get; set; }
        protected override void ExecuteOperation(IEntity entity, string queryColumn)
        {
            Performer p = (Performer)entity;

            List<ConcertPerformer> cps = repository.GetAll(new ConcertPerformer()).Cast<ConcertPerformer>().ToList();

            List<Concert> concerts = new List<Concert>();

            foreach(ConcertPerformer cp in cps)
            {
                if (cp.Performer.ID == p.ID)
                {
                    concerts.Add(cp.Concert);
                }
            }

            Result = concerts;
        }
    }
}
