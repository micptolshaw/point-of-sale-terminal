using System;
using System.Collections;
using System.Collections.Generic;

namespace PointOfSale.Test.Data
{
    public class ShoppingLists : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //  Values provided in the spec, to demonstrate correct behaviour
            yield return new object[] { "ABCDABA",  new Decimal(13.25), true };
            yield return new object[] { "CCCCCCC", new Decimal(6.00), true };
            yield return new object[] { "ABCD", new Decimal(7.25), true };

            // Invalid price to demonstrate incorrect behaviour is detected by the tests
            yield return new object[] { "ABCDABA", new Decimal(13.00), false };

            // Additional Items to demonstrate incorrect behaviour is detected by the tests
            yield return new object[] { "CCCCCCCAB", new Decimal(6.00), false };
            yield return new object[] { "ABCDABCD", new Decimal(7.25), false };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
