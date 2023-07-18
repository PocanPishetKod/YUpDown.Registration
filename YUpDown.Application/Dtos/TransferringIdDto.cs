using System.Runtime.Serialization;

namespace YUpDown.Registration.Application.Dtos
{
    [DataContract]
    public struct TransferringIdDto
    {
        [DataMember(Order = 0)]
        public Guid Value { get; init; }
    }
}
