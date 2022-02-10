using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DbPractices.DataAccess.EntityFramework.Abstract;
using DbPractices.Entities;

namespace DbPractices.DataAccess.EntityFramework.Concrete
{
    public class EfGradeDal : EfRepositoryBase<Grade>,IEfGradeDal
    {
        public EfGradeDal(SchoolDbContext context) : base(context)
        {
        }
    }
}
