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
            foreach(var item in shoppingList)
            {
                terminal.ScanProduct(item);
            }

            // Act
            var calculatedPrice = terminal.CalculateTotal();

            // Assert
            Assert.Equal(validatePriceValid, calculatedPrice == validatePrice);
        }
    }
}
