using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using Dapper;
using DbPractices.DataAccess.Dapper.Abstract;


namespace DbPractices.DataAccess.Dapper.Concrete
{
    public class DpRepositoryBase<T> : IDpRepostioryBase<T>
    {
        private readonly IDbConnection _dbConnection;
        public DpRepositoryBase(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public List<T> GetAll()
        {
            var attribute =
                (TableAttribute)typeof(T).GetCustomAttributes(typeof(TableAttribute), true)[0];
            string sql = $"Select * From {attribute.Name}";

            return _dbConnection.Query<T>(sql).ToList();
        }

        public T Get(int id)
        {
            string primaryKey = "";

            var table =
                (TableAttribute)typeof(T).GetCustomAttributes(typeof(TableAttribute), true)[0];

            foreach (PropertyInfo prop in typeof(T).GetProperties())
            {
                foreach (var attr in prop.GetCustomAttributes(false))
                {

                    if (attr is KeyAttribute)
                    {
                        primaryKey = prop.Name;
                    }
                }
            }

            string sql = $"Select * From {table.Name} Where {primaryKey} = {id};";

            return _dbConnection.QueryFirstOrDefault<T>(sql);
        }
    }
}
