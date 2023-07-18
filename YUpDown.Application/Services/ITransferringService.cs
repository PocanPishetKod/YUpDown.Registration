using YUpDown.Registration.Application.Dtos;

namespace YUpDown.Registration.Application.Services
{
    public interface ITransferringService
    {
        Task<RegistrationResultDto> Register(RegistrationDto registration);
    }
}
