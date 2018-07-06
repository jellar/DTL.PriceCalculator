namespace PriceCalculation
{
    public interface ICalculator
    {
        Checkout Calculate(Basket basket);
    }
}
