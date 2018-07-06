using System.Collections.Generic;

namespace PriceCalculation
{
    public class Basket
    {
        public List<Product> Products = new List<Product>();

        public void Add(Product product)
        {
            Products.Add(product);
        }

        public void Remove(Product product)
        {
            Products.Remove(product);
        }
    }
}