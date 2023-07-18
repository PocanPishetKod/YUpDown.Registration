using System.Runtime.Serialization;
using YUpDown.Registration.Application.Dtos;

namespace YUpDown.Registration.Application.Events
{
    [DataContract]
    public class TransferringRegisteredEvent
    {
        [DataMember(Order = 0)]
        public TransferringDto Transferring { get; }

        public TransferringRegisteredEvent(TransferringDto transferring)
        {
            Transferring = transferring ?? throw new ArgumentNullException(nameof(transferring));
        }
    }
}
