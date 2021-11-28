using System;
using System.Collections;
using System.Collections.Generic;
using PointOfSale.Model;

namespace PointOfSale.Test.Data
{
    public class PriceDataValues : IEnumerable<ItemPriceData>
    {

        public IEnumerator<ItemPriceData> GetEnumerator()
        {
            yield return new ItemPriceData('A', 1, new decimal(1.25));
            yield return new ItemPriceData('A', 3, new decimal(3.00));
            yield return new ItemPriceData('B', 1, new decimal(4.25));
            yield return new ItemPriceData('C', 1, new decimal(1.00));
            yield return new ItemPriceData('C', 6, new decimal(5.00));
            yield return new ItemPriceData('D', 1, new decimal(0.75));
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    }
}