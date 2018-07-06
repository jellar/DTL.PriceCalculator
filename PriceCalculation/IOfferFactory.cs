namespace PriceCalculation
{
    public interface IOfferFactory
    {
        IOffer GetOffer(Product product);
    }
}
