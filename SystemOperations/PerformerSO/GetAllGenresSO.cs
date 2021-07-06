using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.PerformerSO
{
    public class GetAllGenresSO : SystemOperationBase
    {

        public List<Genre> Result { get; set; }
        protected override void ExecuteOperation(IEntity entity, string queryColumn)
        {
            Result = repository.GetAll(new Genre()).Cast<Genre>().ToList();
        }
    }
}
