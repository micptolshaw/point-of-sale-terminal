using System;

namespace PointOfSale
{
    public class PointOfSaleTerminal : IPointOfSaleTerminal
    {
        public decimal CalculateTotal() => throw new NotImplementedException();

        public void ScanProduct(char productCode) => throw new NotImplementedException();

        public void SetPricing() => throw new NotImplementedException();
    }
}
