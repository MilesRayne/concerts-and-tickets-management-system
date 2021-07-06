using DatabaseBroker;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Implementation.Database
{
    public class GenericRepository : IGenericRepository
    {
        private Broker broker = new Broker();
        public void BeginTransaction()
        {
            broker.BeginTransaction();
        }

        public void CloseConnection()
        {
            broker.CloseConnection();
        }

        public void Commit()
        {
            broker.Commit();
        }

        public void Delete(IEntity entity, int id)
        {
            broker.Delete(entity, id);
        }

        public List<IEntity> GetAll(IEntity entity)
        {
            return broker.GetAll(entity);
        }

        public List<IEntity> GetByQuery(IEntity e, string queryColumn, string query)
        {
            return broker.GetByQuery(e, queryColumn, query);
        }

        public int GetNewId(IEntity e)
        {
            return broker.GetNewId(e);
        }

        public void OpenConnection()
        {
            broker.OpenConnection();
        }

        public void Rollback()
        {
            broker.Rollback();
        }

        public void Save(IEntity entity)
        {
            broker.Save(entity);
        }

        public void Update(IEntity entity, string set, int id)
        {
            broker.Update(entity, set, id);
        }
    }
}
