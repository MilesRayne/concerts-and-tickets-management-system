using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemOperations.UserSO
{
    public class LoginSO : SystemOperationBase
    {
        public User Result { get; set; }
        protected override void ExecuteOperation(IEntity entity, string queryColumn)
        {

            List<User> users = repository.GetAll(new User()).Cast<User>().ToList();

            //Get user object from entity
            User u = (User)entity;

            bool userFound = false;

            foreach (User user in users)
            {
                if (u.Username == user.Username && u.Password == user.Password)
                {
                    Result = user;
                    userFound = true;
                } 
            }

            if (!userFound)
            {
                throw new Exception("Pogresni kredencijali za prijavu!");
            }
        }
    }
}
