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
            return PriceCalculator.Calculate(PriceData, Order);
        }


        public void ScanProduct(char productCode)
        {
            Order.Add(productCode);
        }

        public void SetPricing(PriceData priceData)
        {
            PriceData = priceData;
        }
    }
}
