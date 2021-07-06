using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.AddressSO
{
    public class GetAllAddressesSO : SystemOperationBase
    {

        public List<Address> Result { get; set; }
        protected override void ExecuteOperation(IEntity entity, string queryColumn)
        {
            Result = repository.GetAll(new Address()).Cast<Address>().ToList();
        }
    }
}
