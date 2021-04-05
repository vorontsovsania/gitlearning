using System;

namespace GitLearning.ConsoleClient.Models
{
    public class Money : IEquatable<Money>
    {
        public decimal Value { get; }

        public Money(decimal value)
        {
            Value = value;
        }

        public Money Add(decimal value)
        {
            return new Money(Value + value);
        }

        public Money Subtract(decimal value)
        {
            return new Money(Value - value);
        }

        public Money Multiple(decimal value)
        {
            return new Money(Value * value);
        }

        public bool Equals(Money other)
        {
            if (ReferenceEquals(null, other))
                return false;
            return Value == other.Value;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;

            return obj is Money money && Equals(money);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public static bool operator ==(Money left, Money right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Money left, Money right)
        {
            return !left.Equals(right);
        }
    }
}
