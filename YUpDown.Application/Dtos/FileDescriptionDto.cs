using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace YUpDown.Registration.Application.Dtos
{
    [DataContract]
    public class FileDescriptionDto
    {
        [DataMember(Order = 0)]
        public FileIdDto Id { get; init; }

        [DataMember(Order = 1)]
        [Required(ErrorMessage = "PhysicalPath is required.")]
        public string PhysicalPath { get; init; } = null!;

        [DataMember(Order = 2)]
        [Range(1, long.MaxValue, ErrorMessage = $"Size must be between 1 and long.MaxValue")]
        public long Size { get; init; }
    }
}
