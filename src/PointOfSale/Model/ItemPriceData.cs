namespace PointOfSale.Model
{
    public class ItemPriceData
    {
        public ProductCode ProductCode { get; }

        public int Quantity { get; }

        public decimal Price { get; }

        public decimal PricePerItem { get; }

        public ItemPriceData(ProductCode productCode, int quantity, decimal price)
        {
            ProductCode = productCode;
            Quantity = quantity;
            Price = price;
            PricePerItem = price / quantity;
        }
    }
}
