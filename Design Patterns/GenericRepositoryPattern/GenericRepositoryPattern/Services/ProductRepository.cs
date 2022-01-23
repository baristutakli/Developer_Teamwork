using GenericRepositoryPattern.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericRepositoryPattern.Services
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }

        public IQueryable<Product> GetAllProductsWithCategory()
        {
            return GetAll().Include(m => m.Category);
        }

        public async Task<Product> GetByIdWithCategory(int id)
        {
            return await _context.Products.AsNoTracking().Include(m => m.Category).FirstOrDefaultAsync(m => m.Id == id);
        }
    }
}
