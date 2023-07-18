namespace YUpDown.Registration.Domain.Transferings
{
    public class Transferring
    {
        public TransferringId Id { get; }

        public TransferringType Type { get; }

        public TransferringStatus Status { get; protected set; }

        public IReadOnlyList<FileDescription> FileDescriptions { get; }

        public TransferringToken Token { get; }

        public UserId UserId { get; }

        public Transferring(
            TransferringId id,
            TransferringType type,
            IReadOnlyList<FileDescription> fileDescriptions,
            TransferringToken token,
            UserId userId)
        {
            Id = id ?? throw new ArgumentNullException(nameof(id));
            FileDescriptions = fileDescriptions ?? throw new ArgumentNullException(nameof(fileDescriptions));

            if (FileDescriptions.Count == 0)
                throw new ArgumentException($"{fileDescriptions} count must be more then 0");

            Token = token ?? throw new ArgumentNullException(nameof(token));
            Type = type;
            Status = TransferringStatus.Ready;
            UserId = userId;
        }
    }
}
