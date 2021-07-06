using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class ConcertPerformer : IEntity
    {
        public Concert Concert { get; set; }
        public Performer Performer { get; set; }
        public string TableName => "ConcertPerformer";

        public string InsertValues => $"{Concert.ID}, {Performer.ID}";

        public string IdName => "ConcertId";

        public string JoinCondition => "join address a on (c.addressId = a.Id) join municipality m on (a.municipalityId = m.Id) join genres g on (g.Id = p.genreId)";

        public string JoinTable => "join concerts c on (cp.concertId = c.Id) join performers p on (cp.performerId = p.Id)";

        public string TableAlias => "cp";

        public object SelectValues => "cp.concertId cpcid, cp.performerId cppid, c.Name cname, c.StreetNumber csn, p.ArtistName pan, a.Id aid, a.Name aname, m.Id mid, m.Name mname, g.Id gid, g.Name gname";

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                ConcertPerformer cp = new ConcertPerformer
                {
                    Concert = new Concert
                    {
                        ID = (int)reader["cpcid"],
                        Name = (string)reader["cname"],
                        StreetNumber = (string)reader["csn"],
                        Address = new Address
                        {
                            ID = (int)reader["aid"],
                            Name = (string)reader["aname"],
                            Municipality = new Municipality
                            {
                                ID = (int)reader["mid"],
                                Name = (string)reader["mname"]
                            }
                        }
                    },
                    Performer = new Performer
                    {
                        ID = (int)reader["cppid"],
                        ArtistName = (string)reader["pan"],
                        Genre = new Genre
                        {
                            ID = (int)reader["gid"],
                            Name = (string)reader["gname"]
                        }
                    },
                };
                result.Add(cp);
            }

            return result;
        }
    }
}
