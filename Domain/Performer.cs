using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Performer : IEntity
    {
        public int ID { get; set; }
        public string ArtistName { get; set; }
        public Genre Genre { get; set; }
        public string TableName => "Performers";

        public string InsertValues => $"'{ArtistName}', {Genre.ID}";

        public string IdName => "Id";
        public string JoinCondition => "on (p.genreId = g.Id)";

        public string JoinTable => "join genres g";

        public string TableAlias => "p";

        public object SelectValues => "p.Id pid, p.ArtistName partistname, g.Id gid, g.Name gname";

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                Performer p = new Performer
                {
                    ID = (int)reader["pid"],
                    ArtistName = (string)reader["partistname"],
                    Genre = new Genre
                    {
                        ID = (int)reader["gid"],
                        Name = (string)reader["gname"]
                    }
                };

                result.Add(p);
            }

            return result;
        }

        public override string ToString()
        {
            return ArtistName + " (" + Genre.Name + ")";
        }
    }
}
