using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using DbPractices.DataAccess.Dapper.Abstract;
using DbPractices.Entities;

namespace DbPractices.DataAccess.Dapper.Concrete
{
    public class DpGradeGal : DpRepositoryBase<Grade>,IDpGradeDal
    {
        public DpGradeGal(IDbConnection dbConnection) : base(dbConnection)
        {
        }

    }
}
