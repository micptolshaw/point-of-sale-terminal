using System;
using System.Collections.Generic;
using System.Linq;
using PointOfSale.Model;

namespace PointOfSale.BusinessRules
{
    public static class OrderCalculator
    {
        public static decimal Calculate(PriceData priceData, Order order)
        {
            return order.Items().Aggregate(
                new decimal(0),
                (total, itemCode) => total + CalculateCheapestPrice(priceData.GetPriceListForItemCode(itemCode), order.GetItemCount(itemCode)));

        }

        private static decimal CalculateCheapestPrice(IEnumerable<ProductPriceData> itemPriceDataEnumerable, int itemCount)
        {
           var cheapestFirst = itemPriceDataEnumerable.OrderBy(itemPriceData => itemPriceData.PricePerItem);
           var cheapestPrice = cheapestFirst.Aggregate( new Tuple<decimal, int>(new decimal(0), itemCount), CalculateItemCostAndUpdateState);

           return cheapestPrice.Item1;
        }


        private static Tuple<decimal, int> CalculateItemCostAndUpdateState(Tuple<decimal, int> state, ProductPriceData productPriceData)
        {
            var costData = CalculateItemCost(productPriceData, state.Item2);
            return new Tuple<decimal, int>(state.Item1 + costData.Item1, state.Item2 - costData.Item2);
        }

        private static Tuple<decimal, int> CalculateItemCost(ProductPriceData productPriceData, int itemCount)
        {
            int units = (itemCount / productPriceData.Quantity);
            return new Tuple<decimal, int>(
                productPriceData.Price * units,
                productPriceData.Quantity * units 
            );
        }
    }
}
