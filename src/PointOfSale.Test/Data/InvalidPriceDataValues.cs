using System.Collections;
using System.Collections.Generic;
using PointOfSale.Model;

namespace PointOfSale.Test.Data
{
    public class InvalidPriceDataValues : IEnumerable<ProductPriceData>
    {

        public IEnumerator<ProductPriceData> GetEnumerator()
        {
            yield return new ProductPriceData(new ProductCode('A'), 1, new decimal(1.25));
            yield return new ProductPriceData(new ProductCode('A'), 3, new decimal(3.00));
            yield return new ProductPriceData(new ProductCode('B'), 1, new decimal(4.25));
            yield return new ProductPriceData(new ProductCode('C'), 2, new decimal(2.50));
            yield return new ProductPriceData(new ProductCode('C'), 6, new decimal(5.00));
            yield return new ProductPriceData(new ProductCode('D'), 1, new decimal(0.75));
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    }
}
