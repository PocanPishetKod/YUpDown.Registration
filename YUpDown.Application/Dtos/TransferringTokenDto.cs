using System.Runtime.Serialization;

namespace YUpDown.Registration.Application.Dtos
{
    [DataContract]
    public struct TransferringTokenDto
    {
        [DataMember(Order = 0)]
        public string Value { get; init; }
    }
}
