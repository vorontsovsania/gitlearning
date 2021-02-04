namespace GitLearning.ConsoleClient.Models
{
    public class Money
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
    }
}
