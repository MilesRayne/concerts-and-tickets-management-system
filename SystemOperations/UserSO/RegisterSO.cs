using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.UserSO
{
    public class RegisterSO : SystemOperationBase
    {

        public User Result { get; set; }
        protected override void ExecuteOperation(IEntity entity, string queryColumn)
        {
            List<User> users = repository.GetAll(new User()).Cast<User>().ToList();

            //Get user object from entity
            User u = (User)entity;

            foreach (User user in users)
            {

                if (u.Username == user.Username)
                {
                    throw new Exception("Nalog sa datim korisničkim imenom već postoji!");
                }

                if (u.Email == user.Email)
                {
                    throw new Exception("Nalog je već kreiran za datu e-mail adresu.");
                }            
            }
            repository.Save(u);
            Result = u;
        }
    }
}
