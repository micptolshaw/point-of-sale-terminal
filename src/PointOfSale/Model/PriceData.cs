using System.Collections.Generic;
using System.Linq;

namespace PointOfSale.Model
{
    public class PriceData
    {
        private List<ProductPriceData> PriceList { get; }


        public PriceData(IEnumerable<ProductPriceData> priceList)
        {
            PriceList = new List<ProductPriceData>(priceList);
        }

        public IEnumerable<ProductPriceData> GetPriceList()
        {
            return PriceList;
        }

        public IEnumerable<ProductPriceData> GetPriceListForItemCode(ProductCode productCode)
        {
            return GetPriceList().Where(x => x.ProductCode == productCode);
        }

    }
}
