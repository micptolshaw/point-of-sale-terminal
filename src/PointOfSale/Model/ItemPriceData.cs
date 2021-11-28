namespace PointOfSale.Model
{
    public class ItemPriceData
    {
        public ItemCode ItemCode { get; }

        public int Quantity { get; }

        public decimal Price { get; }

        public decimal PricePerItem { get; }

        public ItemPriceData(ItemCode itemCode, int quantity, decimal price)
        {
            ItemCode = itemCode;
            Quantity = quantity;
            Price = price;
            PricePerItem = price / quantity;
        }
    }
}
