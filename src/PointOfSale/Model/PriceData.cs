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

        public IEnumerable<ItemPriceData> GetPriceListForItemCode(ProductCode productCode)
        {
            return GetPriceList().Where(x => x.ProductCode == productCode);
        }

    }
}
