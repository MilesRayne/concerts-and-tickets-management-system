using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Municipality : IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int ZIP { get; set; }
        public string City { get; set; }
        public string TableName => throw new NotImplementedException();

        public string InsertValues => throw new NotImplementedException();

        public string IdName => throw new NotImplementedException();

        public string JoinCondition => throw new NotImplementedException();

        public string JoinTable => throw new NotImplementedException();

        public string TableAlias => throw new NotImplementedException();

        public object SelectValues => throw new NotImplementedException();

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{City}";
        }
    }
}
