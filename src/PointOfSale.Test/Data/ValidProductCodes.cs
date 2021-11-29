using System.Collections;
using System.Collections.Generic;
using PointOfSale.Model;

namespace PointOfSale.Test.Data
{
    public class ValidProductCodes : IEnumerable<ProductCode>
    {
        public IEnumerator<ProductCode> GetEnumerator()
        {
            yield return new ProductCode('A');
            yield return new ProductCode('B');
            yield return new ProductCode('C');
            yield return new ProductCode('D');
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    }
}
