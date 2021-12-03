using System;
using PointOfSale.Model;

namespace PointOfSale.Exceptions
{
    public class ScanProductException : PointOfSaleException
    {
        private static readonly string ProductCodeKey = "PRODUCT_CODE";

        public ScanProductException(ProductCode productCode, Exception source) : base("ScanProduct() has thrown an error", source)
        {
            ProductCode = productCode;
        }

        public ProductCode ProductCode
        {
            get => Data[ProductCodeKey] as ProductCode ?? throw new InvalidOperationException("This value should have been set in the exception constructor");
            private set => Data[ProductCodeKey] = value;
        }
    }
}
