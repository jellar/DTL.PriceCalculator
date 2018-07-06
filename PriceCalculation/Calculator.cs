using System.Linq;

namespace PriceCalculation
{
    public class Calculator : ICalculator
    {
        private readonly IOfferFactory _offerFactory;

        public Calculator()
        {
            _offerFactory = new OfferFactory();
        }

        public Checkout Calculate(Basket basket)
        {
            var checkout = new Checkout
            {
                Products = basket.Products,
                ProductsTotal = basket.Products.Sum(p => p.Price * p.Quantity),
                OfferTotal = basket.Products.Select(product => _offerFactory.GetOffer(product))
                    .Where(offer => offer != null).Sum(offer => offer.GetTotalOffer(basket))
            };
            return checkout;
        }
    }
}