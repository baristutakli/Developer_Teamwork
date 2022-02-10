using System.Collections.Generic;
using System.Linq;
using DbPractices.DataAccess.EntityFramework.Abstract;
using DbPractices.Entities;

namespace DbPractices.DataAccess.EntityFramework.Concrete
{
    public class EfRepositoryBase<TEntity> : IEfRepostitoryBase<TEntity> where TEntity : class,new()
    {
        public SchoolDbContext SchoolDbContext { get; set; }

        public EfRepositoryBase(SchoolDbContext context)
        {
            SchoolDbContext = context;
        }

        public void Add(TEntity entity)
        {
            SchoolDbContext.Set<TEntity>().Add(entity);
            SchoolDbContext.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            SchoolDbContext.Set<TEntity>().Update(entity);
            SchoolDbContext.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            SchoolDbContext.Set<TEntity>().Remove(entity);
            SchoolDbContext.SaveChanges();
        }

    }
}
