using System;
using System.Collections.Generic;
using System.Linq;
using PointOfSale.Model;

namespace PointOfSale.Validators
{
    public class ProductCodeValidator
    {
        private IEnumerable<ProductCode> ValidProductCode { get; }

        public ProductCodeValidator(IEnumerable<ProductCode> validProductCodes)
        {
            ValidProductCode = validProductCodes;
        }

        public void Validate(ProductCode productCode)
        {
            if (!ValidProductCode.Contains(productCode)) throw new ArgumentException("Validation check failed for productCode", paramName: nameof(productCode));
        }
    }
}
