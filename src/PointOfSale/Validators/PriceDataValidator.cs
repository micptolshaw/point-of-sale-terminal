using System;
using System.Linq;
using PointOfSale.Model;

namespace PointOfSale.Validators
{
    public class PriceDataValidator
    {
        public void Validate(PriceData priceData)
        {
            var productsWithPriceForSingleItem = priceData.GetPriceList().Where(product => product.Quantity == 1)
                .Select(product => product.ProductCode);

            var allProducts = priceData.GetPriceList().Select(itemPriceData => itemPriceData.ProductCode).Distinct();

            if (allProducts.Any(productCode => !productsWithPriceForSingleItem.Contains(productCode)))
            {
                throw new ArgumentException("Validation check failed for priceData", nameof(priceData));
            }
        }
    }
}
