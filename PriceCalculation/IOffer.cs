namespace PriceCalculation
{
    public interface IOffer
    {
        string Product { get; }
        int QuantityRequired { get; }
        string ProductWithOffer { get; }
        decimal OfferAmount { get; }
        bool CheckOfferEligibility(Product product, Product productWithOffer);
        decimal GetTotalOffer(Basket basket);
    }
}
