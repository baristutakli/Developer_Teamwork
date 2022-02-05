using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Product.Domain.Common
{
    public interface IRepository<TEntity>
    {
        Task<int> Add(TEntity  entity);
        Task<int> Delete(TEntity  entity);
        Task<int> Update(TEntity  entity);
        Task<List<TEntity  >> GetAll();
        Task<TEntity  > GetById(int id);
        Task<IList<TEntity  >> Get(Expression<Func<TEntity  , bool>> filter);
    }
}
