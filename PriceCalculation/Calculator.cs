using System.Linq;

namespace PriceCalculation
{
    public class Calculator
    {
        public decimal GetTotal(Basket basket)
        {
            return basket.Products.Sum(p => p.Price * p.Quantity);
        }
    }
}