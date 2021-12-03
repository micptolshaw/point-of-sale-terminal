using System;
using PointOfSale.Model;

namespace PointOfSale.Exceptions
{
    public class SetPriceDataException : PointOfSaleException
    {
        private static readonly string PriceDataKey = "PRICE_DATA";

        public SetPriceDataException(PriceData priceData, Exception source) : base ("SetPricing() has thrown an error", source)
        {
            PriceData = priceData;
        }

        public PriceData PriceData
        {
            get => Data[PriceDataKey] as PriceData ?? throw new InvalidOperationException("This value should have been set in the exception constructor");
            private set => Data[PriceDataKey] = value;
        }
    }
}
