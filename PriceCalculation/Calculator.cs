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

        public decimal GetTotal(Basket basket)
        {
            var discount = basket.Products.Select(product => _offerFactory.GetOffer(product)).Where(offer => offer != null).Sum(offer => offer.GetTotalOffer(basket));
            return basket.Products.Sum(p => p.Price * p.Quantity) - discount;
        }
    }
}