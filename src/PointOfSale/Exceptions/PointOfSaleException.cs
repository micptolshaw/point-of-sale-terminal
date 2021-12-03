using System;

namespace PointOfSale.Exceptions
{
    public class PointOfSaleException : Exception
    {
        public PointOfSaleException(string? message, Exception source) : base(message, source)
        {
        }
    }
}
