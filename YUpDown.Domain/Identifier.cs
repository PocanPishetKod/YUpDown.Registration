namespace YUpDown.Registration.Domain
{
    public abstract class Identifier<T>
    {
        public T Value { get; }

        public Identifier(T value)
        {
            Value = value ?? throw new ArgumentNullException(nameof(value));
        }
    }
}
