using System;

namespace PointOfSale.Model
{
    public class ItemCode : IEquatable<ItemCode>
    {
        public char Value { get; }

        public ItemCode(char value)
        {
            Value = value;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as ItemCode);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public bool Equals(ItemCode other)
        {
            return Value.Equals(other.Value);
        }

        public static bool operator ==(ItemCode a, ItemCode b)
        {
            return Equals(a, b);
        }

        public static bool operator !=(ItemCode a, ItemCode b)
        {
            return !Equals(a, b);
        }
    }
}
