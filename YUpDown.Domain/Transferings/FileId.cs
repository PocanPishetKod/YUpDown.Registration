namespace YUpDown.Registration.Domain.Transferings
{
    public readonly struct FileId
    {
        public readonly Guid Value;

        public FileId(Guid value)
        {
            Value = value;
        }
    }
}
