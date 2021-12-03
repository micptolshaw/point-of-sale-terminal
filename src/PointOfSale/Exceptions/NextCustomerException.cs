using System;

namespace PointOfSale.Exceptions
{
    public class NextCustomerException : PointOfSaleException
    {
        public NextCustomerException(Exception source) : base("NextCustomer() has thrown an error", source)
        {

        }
    }
}
