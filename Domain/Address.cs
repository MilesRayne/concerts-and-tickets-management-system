using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{

    [Serializable]
    public class Address : IEntity
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public Municipality Municipality { get; set; }
        public string TableName => "Address";

        public string InsertValues => throw new NotImplementedException();

        public string IdName => "Id";

        public string JoinCondition => "on (a.MunicipalityId = m.Id)";

        public string JoinTable => "join municipality m";

        public string TableAlias => "a";

        public object SelectValues => "a.Id aid, a.Name aname, m.Id mid, m.Name mname, m.ZIP mzip, m.City mcity";

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while(reader.Read())
            {
                Address a = new Address
                {
                    ID = (int)reader["aid"],
                    Name = (string)reader["aname"],
                    Municipality = new Municipality
                    {
                        ID = (int)reader["mid"],
                        Name = (string)reader["mname"],
                        ZIP = (int)reader["mzip"],
                        City = (string)reader["mcity"]
                    }
                };

                result.Add(a);
            }

            return result;
        }

        public override string ToString()
        {
            return Name + ", " + Municipality.Name;
        }
    }
}
