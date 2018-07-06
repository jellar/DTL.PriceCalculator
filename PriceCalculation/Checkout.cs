using System.Collections.Generic;

namespace PriceCalculation
{
    public class Checkout
    {
        public decimal ProductsTotal { get; set; }
        public decimal OfferTotal { get; set; }
        public IList<Product> Products { get; set; }
    }
}
