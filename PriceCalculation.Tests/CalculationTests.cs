using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace PriceCalculation.Tests
{
    [TestClass]
    public class CalculationTests
    {
        [TestMethod]
        public void Calculate_total_prices()
        {
            var calculator = new Calculator();

            var products = new List<Product>()
            {
                new Product() {Name = "butter", Quantity = 1, Price = 0.80m},
                new Product() {Name = "milk", Quantity = 1, Price = 1.15m},
                new Product() {Name = "bread", Quantity = 1, Price = 1.00m}
            };

            var basket = new Basket();
            foreach (var product in products)
            {
                basket.Add(product);
            }

            var checkout = calculator.Calculate(basket);
            var result = checkout.ProductsTotal - checkout.OfferTotal;

            Assert.AreEqual(result, 2.95m);
        }

        [TestMethod]
        public void Calculate_total_price_with_milk_offer()
        {
            var calculator = new Calculator();

            var basket = new Basket();
            basket.Add(new Product() { Name = "milk", Quantity = 4, Price = 1.15m });

            var checkout = calculator.Calculate(basket);
            var result = checkout.ProductsTotal - checkout.OfferTotal;

            Assert.AreEqual(result, 3.45m);

        }

        [TestMethod]
        public void Calculate_total_price_with_butter_offer()
        {
            var calculator = new Calculator();

            var basket = new Basket();
            basket.Add(new Product() { Name = "butter", Quantity = 2, Price = 0.80m });
            basket.Add(new Product() { Name = "bread", Quantity = 2, Price = 1.00m });

            var checkout = calculator.Calculate(basket);
            var result = checkout.ProductsTotal - checkout.OfferTotal;
            Assert.AreEqual(result, 3.10m);

        }

        [TestMethod]
        public void Calculate_total_price_with_both_offers()
        {
            var calculator = new Calculator();

            var products = new List<Product>()
            {
                new Product() {Name = "butter", Quantity = 2, Price = 0.80m},
                new Product() {Name = "milk", Quantity = 8, Price = 1.15m},
                new Product() {Name = "bread", Quantity = 1, Price = 1.00m}
            };

            var basket = new Basket();
            foreach (var product in products)
            {
                basket.Add(product);
            }

            var checkout = calculator.Calculate(basket);
            var result = checkout.ProductsTotal - checkout.OfferTotal;

            Assert.AreEqual(result, 9.00m);
        }
    }
}
