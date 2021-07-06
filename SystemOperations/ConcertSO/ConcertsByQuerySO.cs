using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.ConcertSO
{
    public class ConcertsByQuerySO : SystemOperationBase
    {
        public List<Concert> Result { get; set; }
        protected override void ExecuteOperation(IEntity entity, string queryColumn)
        {
            Concert c = (Concert)entity;
            Result = repository.GetByQuery(new Concert(), queryColumn, c.Name).Cast<Concert>().ToList();
        }
    }
}
