using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.PerformerSO
{

   
    public class SavePerformerSO : SystemOperationBase
    {

        public Performer Result { get; set; }
        protected override void ExecuteOperation(IEntity entity, string queryColumn)
        {
            Performer p = (Performer)entity;
            repository.Save(p);
            Result = p;
        }
    }
}
