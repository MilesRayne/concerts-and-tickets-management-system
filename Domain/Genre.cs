using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Genre : IEntity
    {

        public int ID { get; set; }
        public string Name { get; set; }

        public string TableName => "Genres";

        public string InsertValues => throw new NotImplementedException();

        public string IdName => "Id";

        public string JoinCondition => "";

        public string JoinTable => "";

        public string TableAlias => "g";

        public object SelectValues => "*";

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                Genre g = new Genre
                {
                    ID = (int)reader["id"],
                    Name = (string)reader["name"]
                };

                result.Add(g);
            }
            return result;
        }


        public override string ToString()
        {
            return Name;
        }
    }
}
