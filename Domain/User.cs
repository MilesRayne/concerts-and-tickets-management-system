using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Domain
{
    [Serializable]
    public class User: IEntity
    {
        public int ID { get; set; }
        public string Username { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public bool isAdmin { get; set; }

        [Browsable(false)]
        public string TableName => "Users";
        [Browsable(false)]
        public string InsertValues => $"'{Username}', '{Password}', 0, '{Name}', '{Surname}', '{Email}'";
        [Browsable(false)]
        public string IdName => "Id";
        [Browsable(false)]
        public string JoinCondition => "";
        [Browsable(false)]
        public string JoinTable => "";
        [Browsable(false)]
        public string TableAlias => "u";
        [Browsable(false)]
        public object SelectValues => "u.Id uid, u.Username uusername, u.Password upassword, u.IsAdmin uisadmin, u.Name uname, u.Surname usurname, u.Email uemail";

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();

            while (reader.Read())
            {
                User u = new User
                {
                    ID = (int)reader["uid"],
                    Username = (string)reader["uusername"],
                    Password = (string)reader["upassword"],
                    isAdmin = Convert.ToBoolean((int)reader["uisadmin"]),
                    Name = (string)reader["uname"],
                    Surname = (string)reader["usurname"],
                    Email = (string)reader["uemail"]
                };
                result.Add(u);
            }

            return result;
        }

        public override string ToString()
        {
            return $"{Username}";
        }
    }
}
