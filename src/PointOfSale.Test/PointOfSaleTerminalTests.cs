using PointOfSale.Model;
using Xunit;
using PointOfSale.Test.Data;
using PointOfSale.Validators;

namespace PointOfSale.Test
{
    public class PointOfSaleTerminalTests
    {
        [Theory]
        [ClassData(typeof(ShoppingLists))]
        public void ComparePrices(string shoppingList, decimal validatePrice, bool validatePriceValid)
        {
            //  Prepare
            var productCodeValidator = new ProductCodeValidator(new ValidProductCodes());
            var terminal = new PointOfSaleTerminal(productCodeValidator, new PriceDataValidator());
            var priceData = new PriceData(new PriceDataValues());

            // Act
            terminal.SetPricing(priceData);
            var order = terminal.NextCustomer();

            foreach (var item in shoppingList)
            {
                terminal.ScanProduct(order, new ProductCode(item));
            }
            var calculatedPrice = terminal.CalculateTotal(order);

            // Assert
            Assert.Equal(validatePriceValid, calculatedPrice == validatePrice);
        }
    }
}
