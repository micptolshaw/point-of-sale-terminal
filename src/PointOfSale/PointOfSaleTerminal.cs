using System.Diagnostics.CodeAnalysis;
using PointOfSale.BusinessRules;
using PointOfSale.Model;
using PointOfSale.Validators;

namespace PointOfSale
{
    public class PointOfSaleTerminal
    {
        private PriceData PriceData { get; set; }
        private ProductCodeValidator ProductCodeValidator { get; }
        private PriceDataValidator PriceValidator { get; }

        public PointOfSaleTerminal([NotNull] ProductCodeValidator productCodeValidator, [NotNull] PriceDataValidator priceValidator)
        {
            ProductCodeValidator = productCodeValidator;
            PriceValidator = priceValidator;
        }

        public Order NextCustomer()
        {
            return new Order();
        }

        public decimal CalculateTotal([NotNull] Order order)
        {
            return OrderCalculator.Calculate(PriceData, order);
        }


        public void ScanProduct([NotNull] Order order, [NotNull] ProductCode productCode)
        {
            ProductCodeValidator.Validate(productCode);
            order.Add(productCode);
        }

        public void SetPricing([NotNull] PriceData priceData)
        {
            PriceValidator.Validate(priceData);
            PriceData = priceData;
        }
    }
}
