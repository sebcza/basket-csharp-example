using System.Collections.Generic;
using System.Linq;
using Windows.UI.Xaml.Media.Animation;

namespace BasketPhone
{
    public class DisplayData
    {
        public DisplayData()
        {

            //MockedData
            Insert(new Display()
            {
                Description = "Lg",
                Id = 1,
                Name = "Lg",
                Price = 120,
                Resolution = "1600x900"
            });

            Insert(new Display()
            {
                Description = "Samsung",
                Id = 2,
                Name = "Lg",
                Price = 120,
                Resolution = "1600x900"
            });

        }
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
