using Product.Application.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Product.Infrastructure.Repository
{
    public class ProductRepository<Product> : IProductRepository<Product>
    {
        public Task<int> Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Product>> Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
