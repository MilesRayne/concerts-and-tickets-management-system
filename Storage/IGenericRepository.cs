using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public interface IGenericRepository
    {
        void Save(IEntity entity);
        List<IEntity> GetAll(IEntity e);

        void Delete(IEntity entity, int id);

        void Update(IEntity entity, string set, int id);
        List<IEntity> GetByQuery(IEntity e, string queryColumn, string query);
        int GetNewId(IEntity e);
        void OpenConnection();
        void CloseConnection();
        void BeginTransaction();
        void Commit();
        void Rollback();
    }
}
