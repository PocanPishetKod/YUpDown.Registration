namespace YUpDown.Registration.Domain.Transferings
{
    public readonly struct UserId
    {
        public readonly Guid Value;

        public UserId(Guid value)
        {
            Value = value;
        }
    }
}
