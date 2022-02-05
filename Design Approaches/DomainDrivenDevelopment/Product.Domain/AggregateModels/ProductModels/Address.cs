using Product.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Domain.AggregateModels.ProductModels
{
    public class Address:ValueObject
    {
        public string City { get; private set; }
        public string Country { get; private set; }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            throw new NotImplementedException();
        }
    }
}
