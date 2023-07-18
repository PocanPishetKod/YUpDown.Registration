using System.Runtime.Serialization;

namespace YUpDown.Registration.Domain.Transferings
{
    [DataContract]
    public enum TransferringType
    {
        Upload,
        Download
    }
}
