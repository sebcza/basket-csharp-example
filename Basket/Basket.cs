using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basket
{
    public class Basket
    {
        public int Count { get; set; }
        public double Total { get; set; }
        public List<Product> Products { get; set; }
    }
}
