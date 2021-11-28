namespace PointOfSale
{
    public interface IPointOfSaleTerminal
    {
        void SetPricing();

        void ScanProduct(char productCode);

        decimal CalculateTotal();
    }
}
