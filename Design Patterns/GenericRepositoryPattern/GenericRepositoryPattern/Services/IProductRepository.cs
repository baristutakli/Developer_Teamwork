using GenericRepositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericRepositoryPattern.Services
{
    public interface IProductRepository : IRepository<Product>
    {
        IQueryable<Product> GetAllProductsWithCategory();
        Task<Product> GetByIdWithCategory(int id);
    }
}
