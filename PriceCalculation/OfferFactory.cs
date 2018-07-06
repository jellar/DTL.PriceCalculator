using System.Collections.Generic;

namespace PriceCalculation
{
    public class OfferFactory : IOfferFactory
    {
        private readonly Dictionary<string, IOffer> _offers = new Dictionary<string, IOffer>();
        public IOffer GetOffer(Product product)
        {
            // store offers in dictionary
            if (_offers.TryGetValue(product.Name, out var offer)) return offer;
            var productName = product.Name.ToLower().Trim();
            switch (productName)
            {
                case "milk":
                    offer = new Offer()
                    {
                        Product = "milk",
                        QuantityRequired = 4,
                        ProductWithOffer = "milk",
                        OfferAmount = 100
                    };
                    break;
                case "butter":
                    offer = new Offer()
                    {
                        Product = "butter",
                        QuantityRequired = 2,
                        ProductWithOffer = "bread",
                        OfferAmount = 50
                    };
                    break;
            }
            _offers.Add(product.Name, offer);
            return offer;
        }
    }
}
