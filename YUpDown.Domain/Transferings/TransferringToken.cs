namespace YUpDown.Registration.Domain.Transferings
{
    public class TransferringToken
    {
        public string Value { get; }

        public TransferringToken(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException(nameof(value));

            Value = value;
        }
    }
}
