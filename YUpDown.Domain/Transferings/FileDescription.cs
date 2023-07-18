namespace YUpDown.Registration.Domain.Transferings
{
    public class FileDescription
    {
        public FileId Id { get; }

        public string PhysicalPath { get; }

        public long Size { get; }

        public FileDescription(FileId id, string path, long size)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException(nameof(path));

            if (size <= 0)
                throw new ArgumentOutOfRangeException(nameof(size));

            Id = id;
            PhysicalPath = path;
            Size = size;
        }
    }
}
