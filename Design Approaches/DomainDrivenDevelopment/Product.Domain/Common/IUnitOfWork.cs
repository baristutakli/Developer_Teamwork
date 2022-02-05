using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Domain.Common
{
    public interface IUnitOfWork
    {
        public Task<int> SaveChangesAsync();
    }
}
