namespace PointOfSale.Model
{
    public class ProductPriceData
    {
        public ProductCode ProductCode { get; }

        public int Quantity { get; }

        public decimal Price { get; }

        public decimal PricePerItem { get; }

        public ProductPriceData(ProductCode productCode, int quantity, decimal price)
        {
            ProductCode = productCode;
            Quantity = quantity;
            Price = price;
            PricePerItem = price / quantity;
        }
    }
}
