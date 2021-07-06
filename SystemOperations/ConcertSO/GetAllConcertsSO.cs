using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.ConcertSO
{
    public class GetAllConcertsSO : SystemOperationBase
    {
        public List<Concert> Result { get; set; }
        protected override void ExecuteOperation(IEntity entity, string queryColumn)
        {
            Result = repository.GetAll(new Concert()).Cast<Concert>().ToList();
        }
    }
}
