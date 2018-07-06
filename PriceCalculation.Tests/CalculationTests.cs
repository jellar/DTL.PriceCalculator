using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace PriceCalculation.Tests
{
    [TestClass]
    public class CalculationTests
    {
        [TestMethod]
        public void Calculate_Total_Prices()
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

            var totalPrice = calculator.GetTotal();

            Assert.AreEqual(totalPrice, 2.95m);
        }
    }
}
