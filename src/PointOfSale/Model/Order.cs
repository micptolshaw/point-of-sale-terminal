using System.Collections.Generic;
using System.Linq;

namespace PointOfSale.Model
{
    public class Order
    {
        private Dictionary<ProductCode, int> ItemTotalsDictionary { get; }


        public Order()
        {
            ItemTotalsDictionary = new Dictionary<ProductCode, int>();
        }


        public void Add(ProductCode productCode)
        {
            if (HasItem(productCode))
            {
                IncreaseItemCount(productCode);
            }
            else
            {
                SetItemCountToOne(productCode);
            }
        }

        public IEnumerable<ProductCode> Items()
        {
            return ItemTotalsDictionary.Keys;
        }

        public int GetItemCount(ProductCode productCode)
        {
            return HasItem(productCode) ? GetItemCountImpl(productCode) : 0;
        }

        private bool HasItem(ProductCode productCode)
        { 
            return ItemTotalsDictionary.Keys.Contains(productCode);
        }

        private void IncreaseItemCount(ProductCode productCode)
        {
            ItemTotalsDictionary[productCode] = ItemTotalsDictionary[productCode] + 1;
        }

        private void SetItemCountToOne(ProductCode productCode)
        {
            ItemTotalsDictionary[productCode] = 1;
        }

        private int GetItemCountImpl(ProductCode productCode)
        {
            return ItemTotalsDictionary[productCode];
        }
    }
}
