using System.Collections.Generic;
using System.Linq;

namespace PointOfSale.Model
{
    public class Order
    {
        private Dictionary<char, int> ItemTotalsDictionary { get; }


        public Order()
        {
            ItemTotalsDictionary = new Dictionary<char, int>();
        }


        public void Add(char itemCode)
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

        public IEnumerable<char> Items()
        {
            return ItemTotalsDictionary.Keys;
        }

        public int GetItemCount(char itemCode)
        {
            return HasItem(itemCode) ? GetItemCountImpl(itemCode) : 0;
        }

        private bool HasItem(char itemCode)
        { 
            return ItemTotalsDictionary.Keys.Contains(itemCode);
        }

        private void IncreaseItemCount(char itemCode)
        {
            ItemTotalsDictionary[itemCode] = ItemTotalsDictionary[itemCode] + 1;
        }

        private void SetItemCountToOne(char itemCode)
        {
            ItemTotalsDictionary[itemCode] = 1;
        }

        private int GetItemCountImpl(char itemCode)
        {
            return ItemTotalsDictionary[itemCode];
        }
    }
}
