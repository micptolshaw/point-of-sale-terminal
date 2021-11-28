using PointOfSale.BusinessRules;
using PointOfSale.Model;

namespace PointOfSale
{
    public class PointOfSaleTerminal
    {
        private PriceData PriceData { get; set; }

        private Order Order { get; }

        public PointOfSaleTerminal()
        {
            Order = new Order();
        }

        public decimal CalculateTotal()
        {
            return OrderCalculator.Calculate(PriceData, Order);
        }


        public void ScanProduct(ProductCode productCode)
        {
            //!TODO: need to validate productCode
            Order.Add(productCode);
        }

        public void SetPricing(PriceData priceData)
        {
            //!TODO: need to validate priceData
            PriceData = priceData;
        }
    }
}
