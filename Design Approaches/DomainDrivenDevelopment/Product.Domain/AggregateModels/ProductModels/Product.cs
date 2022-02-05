using Product.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Domain.AggregateModels.ProductModels
{
    public class Product : BaseEntity, IAggregateRoot
    {

        public int CategoryId { get; private set; }
        public string ProductName { get; private set; }
        public string Explanation { get; private set; }
        public DateTime PublishDate { get; private set; }
        public int SupplierId { get; private set; }
        public ProductDetail ProductDetail { get; private set; }
        public bool ProductStatus { get; private set; }

        public Product(int categoryId, string productName, string explanation, DateTime publishDate, int supplierId, ProductDetail productDetail, bool productStatus)
        {
            //Validasyon kontrolleri buradan yapılabilir

            CategoryId = categoryId;
            ProductName = productName;
            Explanation = explanation;
            PublishDate = publishDate;
            SupplierId = supplierId;
            ProductDetail = productDetail;
            ProductStatus = productStatus;
        }
        public void AddProductDetail()
        {
            ProductDetail detail = new ProductDetail();
            ProductDetail = detail;
        }
    }
}
