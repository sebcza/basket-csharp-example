using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basket
{
    public class DisplayData
    {
        private List<Display> products;

        public void Insert(Display product)
        {
            products.Add(product);
        }

        public Display Get(int id)
        {
            return products.SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<Display> Get()
        {
            return products;
        }
    }
}
