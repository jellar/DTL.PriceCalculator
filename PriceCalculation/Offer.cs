using System;
using System.Linq;

namespace PriceCalculation
{
    public class Offer : IOffer
    {
        public string Product { get; set; }
        public int QuantityRequired { get; set; }
        public string ProductWithOffer { get; set; }
        public decimal OfferAmount { get; set; }

        public bool CheckOfferEligibility(Product product, Product productWithOffer)
        {
            return product != null && productWithOffer != null && product.Quantity >= QuantityRequired;
        }

        public decimal GetTotalOffer(Basket basket)
        {
            var product = basket.Products.FirstOrDefault(p => p.Name == Product);

            var productWithOffer = basket.Products.FirstOrDefault(p => p.Name == ProductWithOffer);

            if (CheckOfferEligibility(product, productWithOffer))
            {
                return GetTotalOffer(product, productWithOffer);
            }
            return 0.00m;
        }

        private decimal GetTotalOffer(Product product, Product productWithOffer)
        {
            var total = 0.00m;
            var noOfOfferItems = Math.Floor((decimal)product.Quantity / QuantityRequired);

            total += noOfOfferItems * productWithOffer.Price * OfferAmount / 100;

            return total;
        }
    }
}
