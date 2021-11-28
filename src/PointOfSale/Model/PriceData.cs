using System.Collections.Generic;
using System.Linq;

namespace PointOfSale.Model
{
    public class PriceData
    {
        private List<ItemPriceData> PriceList { get; }


        public PriceData(IEnumerable<ItemPriceData> priceList)
        {
            PriceList = new List<ItemPriceData>(priceList);
        }

        public IEnumerable<ItemPriceData> GetPriceList()
        {
            return PriceList;
        }

        public IEnumerable<ItemPriceData> GetPriceListForItemCode(ItemCode itemCode)
        {
            return GetPriceList().Where(x => x.ItemCode == itemCode);
        }

    }
}
