using System.Data;
using System.Linq;
using Dapper;
using DbPractices.DataAccess.Dapper.Abstract;
using DbPractices.Entities;

namespace DbPractices.DataAccess.Dapper.Concrete
{
    public class DpStudentDal : DpRepositoryBase<Student>,IDpStudentDal
    {
        private readonly IDbConnection _dbConnection;
        public DpStudentDal(IDbConnection dbConnection) : base(dbConnection)
        {
            _dbConnection = dbConnection;
        }

    }
}
