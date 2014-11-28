using System;
using System.Collections.Generic;
using System.Linq;
using Windows.UI.Xaml.Media.Animation;

namespace BasketPhone
{
    public class DisplayData
    {
        private List<Display> products = new List<Display>();
        public DisplayData()
        {
            
            //MockedData
            Insert(new Display()
            {
                Description = "Lg",
                Id = Guid.NewGuid().ToString(),
                Name = "Lg",
                Price = 120,
                Resolution = "1600x900"
            });

            Insert(new Display()
            {
                Description = "Samsung",
                Id = Guid.NewGuid().ToString(),
                Name = "Samsung",
                Price = 120,
                Resolution = "1600x900"
            });

        }
        

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
