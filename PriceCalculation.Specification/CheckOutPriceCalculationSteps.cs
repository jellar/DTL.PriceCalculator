using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace PriceCalculation.Specification
{
    [Binding]
    public class CheckOutPriceCalculationSteps
    {
        private Basket _basket;
        private Checkout _checkout;
        [Given(@"the basket has")]
        public void GivenTheBasketHas(Table table)
        {
            var products = table.CreateSet<Product>().ToList();
            _basket = new Basket();
            _basket.Products = products;

        }

        [When(@"I calculate checkout total")]
        public void WhenICalculateCheckoutTotal()
        {
            var calculator = new Calculator();
            _checkout =  calculator.Calculate(_basket);
        }

        [Then(@"the total price should be (.*)")]
        public void ThenTheTotalPriceShouldBe(string price)
        {

            Assert.AreEqual(Convert.ToDecimal(price) , _checkout.ProductsTotal - _checkout.OfferTotal);
        }
    }
}
