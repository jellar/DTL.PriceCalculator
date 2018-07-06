namespace PriceCalculation
{
    public class OfferFactory : IOfferFactory
    {
        public IOffer GetOffer(Product product)
        {
            return new Offer()
            {
                Product = "milk",
                QuantityRequired = 4,
                ProductWithOffer = "milk",
                OfferAmount = 100
            };
        }
    }
}
