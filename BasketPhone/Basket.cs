using System.Collections.Generic;
using Basket;

namespace BasketPhone
{
    public class Basket
    {
        private int _count = 0;

        public int Count
        {
            get
            {
                return _count;
            }
            set { _count = value; }
        }

        private double _total = 0;
        public double Total
        {
            get { return _total; }
            set { _total = value; }
        }

        public List<Display> Products { get; set; }

        public Basket()
        {
            Products = new List<Display>();
        }

        public void Add(Display display)
        {
            Products.Add(display);
            _total += display.Price;
            _count++;
            
        }

        public void Remove(Display display)
        {
            Products.Remove(display);
            _total -= display.Price;
            _count--;
        }
    }
}
