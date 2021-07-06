using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{

    [Serializable]
    public class Concert : IEntity
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
        public Address Address { get; set; }

        public string StreetNumber { get; set; }

        public int TicketPrice { get; set; }

        public int TotalSlots { get; set; }

        public int RemainingSlots { get; set; }

        public List<ConcertPerformer> ConcertPerformers { get; set; }

        public string TableName => "Concerts";

        public string InsertValues => $"{ID}, '{Name}', '{Time}', '{StreetNumber}', {Address.ID}, {TicketPrice}, {TotalSlots}, {RemainingSlots}";

        public string IdName => "Id";

        public string JoinCondition => "join municipality m on (m.Id = a.MunicipalityId)";

        public string JoinTable => "join address a on (a.Id = c.AddressId)";

        public string TableAlias => "c";

        public object SelectValues => "c.Id cid, c.Name cname, c.StreetNumber csn, c.Time ctime, c.TicketPrice cprice, c.TotalSlots cts, c.RemainingSlots crs, a.Id aid, a.Name aname, m.Id mid, m.Name mname, m.City mcity";

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                Concert c = new Concert
                {
                    ID = (int)reader["cid"],
                    Name = (string)reader["cname"],
                    StreetNumber = (string)reader["csn"],
                    Address = new Address
                    {
                        ID = (int)reader["aid"],
                        Name = (string)reader["aname"],
                        Municipality = new Municipality
                        {
                            ID = (int)reader["mid"],
                            Name = (string)reader["mname"],
                            City = (string)reader["mcity"]
                        }
                    },
                    Time = (string)reader["ctime"],
                    TicketPrice = (int)reader["cprice"],
                    TotalSlots = (int)reader["cts"],
                    RemainingSlots = (int)reader["crs"]
                };

                result.Add(c);
            }
            return result;
        }

        public override string ToString()
        {
            return $"{Name}, {Time}";
        }
    }
}
