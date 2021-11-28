using System;

namespace PointOfSale.Model
{
    public class ProductCode : IEquatable<ProductCode>
    {
        public char Value { get; }

        public ProductCode(char value)
        {
            Value = value;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as ProductCode);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public bool Equals(ProductCode other)
        {
            return Value.Equals(other.Value);
        }

        public static bool operator ==(ProductCode a, ProductCode b)
        {
            return Equals(a, b);
        }

        public static bool operator !=(ProductCode a, ProductCode b)
        {
            return !Equals(a, b);
        }
    }
}
