using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DbPractices.Entities;

namespace DbPractices.DataAccess.EntityFramework.Abstract
{
    public interface IEfRepostitoryBase<T>
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}

