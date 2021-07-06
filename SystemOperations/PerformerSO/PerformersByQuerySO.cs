using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.UserSO
{
    public class PerformersByQuerySO : SystemOperationBase
    {

        public List<Performer> Result { get; set; }
        protected override void ExecuteOperation(IEntity entity, string queryColumn)
        {
            Performer p = (Performer)entity;
            Result = repository.GetByQuery(new Performer(), queryColumn, p.ArtistName).Cast<Performer>().ToList();
            

        }

    }
}
