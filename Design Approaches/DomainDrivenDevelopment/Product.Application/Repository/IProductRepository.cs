using Product.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Application.Repository
{
    public interface IProductRepository<Product>:IRepository<Product>
    {
    }
}
