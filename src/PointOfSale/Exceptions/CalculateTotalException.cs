using System;
using PointOfSale.Model;

namespace PointOfSale.Exceptions
{
    public class CalculateTotalException : PointOfSaleException
    {
        private static readonly string OrderKey = "ORDER";

        public CalculateTotalException(Order order, Exception source) : base("CalculateTotal() has thrown an error", source)
        {
            Order = order;
        }
        public Order Order
        {
            get => Data[OrderKey] as Order ?? throw new InvalidOperationException("This value should have been set in the exception constructor");
            private set => Data[OrderKey] = value;
        }
    }
}
