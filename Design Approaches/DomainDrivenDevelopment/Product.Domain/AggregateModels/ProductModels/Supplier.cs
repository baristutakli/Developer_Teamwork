using Product.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Domain.AggregateModels.ProductModels
{
    public class Supplier:BaseEntity
    {
        public string ContactName { get; private set; }
        public string CompanyName { get; private set; }

        public Supplier(string contactName, string companyName)
        {
            ContactName = contactName;
            CompanyName = companyName;
        }
    }
}
