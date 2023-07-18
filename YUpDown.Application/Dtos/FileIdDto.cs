using System.Runtime.Serialization;

namespace YUpDown.Registration.Application.Dtos
{
    [DataContract]
    public struct FileIdDto
    {
        [DataMember(Order = 0)]
        public Guid Value { get; init; }
    }
}
