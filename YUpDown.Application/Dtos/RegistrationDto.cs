using System.ComponentModel.DataAnnotations;
using YUpDown.Registration.Domain.Transferings;

namespace YUpDown.Registration.Application.Dtos
{
    public class RegistrationDto
    {
        [Required(ErrorMessage = "FileDescriptions is required.")]
        public IReadOnlyList<FileDescriptionDto> FileDescriptions { get; init; } = null!;

        public UserIdDto UserId { get; init; }

        public TransferringType TransferringType { get; init; }
    }
}
