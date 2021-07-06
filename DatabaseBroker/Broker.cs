using Domain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseBroker
{
    public class Broker
    {
        private SqlConnection connection;
        private SqlTransaction transaction;

        public Broker()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["BazaSeminarskiRad"].ConnectionString);
        }

        public void OpenConnection()
        {
            connection.Open();
        }

        public void CloseConnection()
        {
            connection.Close();
        }

        public void BeginTransaction()
        {
            transaction = connection.BeginTransaction();
        }

        public void Commit()
        {
            transaction?.Commit();
        }

        public void Rollback()
        {
            transaction?.Rollback();
        }

        public List<IEntity> GetAll(IEntity entity)
        {
            List<IEntity> result;
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"select {entity.SelectValues} from {entity.TableName} {entity.TableAlias} {entity.JoinTable} {entity.JoinCondition}";
            SqlDataReader reader = command.ExecuteReader();
            result = entity.GetEntities(reader);
            reader.Close();
            return result;
        }

        public List<IEntity> GetByQuery(IEntity entity, string queryColumn, string query)
        {
            List<IEntity> result;
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"select {entity.SelectValues} from {entity.TableName} {entity.TableAlias} {entity.JoinTable} {entity.JoinCondition} WHERE {queryColumn} LIKE '%' + '{query}' + '%'";
            SqlDataReader reader = command.ExecuteReader();
            result = entity.GetEntities(reader);
            reader.Close();
            return result;
        }


        public void Save(IEntity entity)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"insert into {entity.TableName} values ({entity.InsertValues})";
            if (command.ExecuteNonQuery() != 1)
            {
                throw new Exception("Database error!");
            }
        }

        public void Delete(IEntity entity, int id)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"DELETE FROM {entity.TableName} WHERE {entity.IdName} = {id}";
            command.ExecuteNonQuery();
        }

        public void Update(IEntity entity, string set, int id)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"UPDATE {entity.TableName} SET {set} WHERE {entity.IdName} = {id}";
            command.ExecuteNonQuery();
        }

        public int GetNewId(IEntity entity)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"select max({entity.IdName}) from {entity.TableName}";
            object result = command.ExecuteScalar();
            if (result is DBNull)
            {
                return 1;
            }
            else
            {
                return (int)result + 1;
            }
        }


    }
}
