using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Ticket : IEntity
    {
        public int ID { get; set; }
        public Concert Concert { get; set; }

        public User User { get; set; }
        [Browsable(false)]
        public string TableName => "Ticket";
        [Browsable(false)]
        public string InsertValues => $"{Concert.ID}, {User.ID}";
        [Browsable(false)]
        public string IdName => "ConcertID";
        [Browsable(false)]
        public string JoinCondition => "join address a on (c.addressId = a.Id) join municipality m on (a.municipalityId = m.Id)";
        [Browsable(false)]
        public string JoinTable => "join concerts c on (t.concertId = c.Id) join users p on (t.userId = p.Id)";
        [Browsable(false)]
        public string TableAlias => "t";
        [Browsable(false)]
        public object SelectValues => "t.Id tid, t.concertId tcid, t.userId tuid, c.Name cname, a.Name aname, c.StreetNumber csn, a.Id aid, m.Id mid, m.Name mname, m.City mcity";

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                Ticket t = new Ticket
                {
                    ID = (int)reader["tid"],
                    Concert = new Concert
                    {
                        ID = (int)reader["tcid"],
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
                    User = new User
                    {
                        ID = (int)reader["tuid"]
                    },
                };
                result.Add(t);
            }

            return result;
        }
    }
}
