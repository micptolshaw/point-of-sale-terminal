using System.Collections.Generic;
using PointOfSale.Model;
using Xunit;
using PointOfSale.Test.Data;

namespace PointOfSale.Test
{
    public class PointOfSaleTerminalTests
    {
        [Theory]
        [ClassData(typeof(ShoppingLists))]
        public void ComparePrices(string shoppingList, decimal validatePrice, bool validatePriceValid)
        {
            //  Prepare
            var terminal = new PointOfSaleTerminal();
            var priceDataValues = new List<ItemPriceData>(new PriceDataValues());
            var priceData = new PriceData(priceDataValues);

            // Act
            terminal.SetPricing(priceData);
            foreach (var item in shoppingList)
            {
                terminal.ScanProduct(item);
            }
            var calculatedPrice = terminal.CalculateTotal();

            // Assert
            Assert.Equal(validatePriceValid, calculatedPrice == validatePrice);
        }
    }
}
