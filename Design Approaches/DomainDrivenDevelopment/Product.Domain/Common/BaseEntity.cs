using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Domain.Common
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }

        // Bütün nesnelerden ortak olarak bir notification fırlatabiliriz
        // Domain e eventler ekleyen bir metod oluştruabiliriz
    }
}
