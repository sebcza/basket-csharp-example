using System.Collections.Generic;
using Basket;

namespace BasketPhone
{
    public class Basket
    {
        public int Count { get; set; }
        public double Total { get; set; }
        public List<Product> Products { get; set; }
    }
}
