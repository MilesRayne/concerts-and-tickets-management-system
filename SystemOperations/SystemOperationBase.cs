﻿using Domain;
using Storage;
using Storage.Implementation.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public abstract class SystemOperationBase
    {
        protected IGenericRepository repository;

        public SystemOperationBase()
        {
            repository = new GenericRepository();
        }

        public void ExecuteTemplate(IEntity entity, string queryColumn = "")
        {
            try
            {
                repository.OpenConnection();
                repository.BeginTransaction();
                ExecuteOperation(entity, queryColumn);
                repository.Commit();
            }
            catch (Exception)
            {
                repository.Rollback();
                throw;
            }
            finally
            {
                repository.CloseConnection();
            }
        }

        protected abstract void ExecuteOperation(IEntity entity, string queryColumn);
    }
}
