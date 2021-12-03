using System;
using System.Diagnostics.CodeAnalysis;
using PointOfSale.BusinessRules;
using PointOfSale.Exceptions;
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
            try
            {
                return new Order();
            }
            catch (Exception ex)
            {
                throw new NextCustomerException(ex);
            }
        }

        public decimal CalculateTotal([NotNull] Order order)
        {
            try
            {
                return OrderCalculator.Calculate(PriceData, order);
            }
            catch (Exception ex)
            {
                throw new CalculateTotalException(order, ex);
            }
        }


        public void ScanProduct([NotNull] Order order, [NotNull] ProductCode productCode)
        {
            try
            {
                ProductCodeValidator.Validate(productCode);
                order.Add(productCode);
            }
            catch (Exception ex)
            {
                throw new ScanProductException(productCode, ex);
            }
        }

        public void SetPricing([NotNull] PriceData priceData)
        {
            try
            {
                PriceValidator.Validate(priceData);
                PriceData = priceData;
            }
            catch (Exception ex)
            {
                throw new SetPriceDataException(priceData, ex);
            }
        }
    }
}
