using System.Collections.Generic;
using System.Linq;

namespace PointOfSale.Model
{
    public class Order
    {
        private Dictionary<ItemCode, int> ItemTotalsDictionary { get; }


        public Order()
        {
            ItemTotalsDictionary = new Dictionary<ItemCode, int>();
        }


        public void Add(ItemCode itemCode)
        {
            if (HasItem(itemCode))
            {
                IncreaseItemCount(itemCode);
            }
            else
            {
                SetItemCountToOne(itemCode);
            }
        }

        public IEnumerable<ItemCode> Items()
        {
            return ItemTotalsDictionary.Keys;
        }

        public int GetItemCount(ItemCode itemCode)
        {
            return HasItem(itemCode) ? GetItemCountImpl(itemCode) : 0;
        }

        private bool HasItem(ItemCode itemCode)
        { 
            return ItemTotalsDictionary.Keys.Contains(itemCode);
        }

        private void IncreaseItemCount(ItemCode itemCode)
        {
            ItemTotalsDictionary[itemCode] = ItemTotalsDictionary[itemCode] + 1;
        }

        private void SetItemCountToOne(ItemCode itemCode)
        {
            ItemTotalsDictionary[itemCode] = 1;
        }

        private int GetItemCountImpl(ItemCode itemCode)
        {
            return ItemTotalsDictionary[itemCode];
        }
    }
}
