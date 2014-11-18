using System.Collections.Generic;
using System.Linq;

namespace Basket
{
    public class ProductData
    {
        private List<Product> products;

        public void Insert(Product product)
        {
            products.Add(product);
        }

        public Product Get(int id)
        {
            return products.SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<Product> Get()
        {
            return products;
        }
    }
}