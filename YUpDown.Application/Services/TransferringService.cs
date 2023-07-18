using YUpDown.Registration.Application.Dtos;
using YUpDown.Registration.Application.Events;
using YUpDown.Registration.Application.Interfaces;
using YUpDown.Registration.Domain.Transferings;

namespace YUpDown.Registration.Application.Services
{
    public class TransferringService : ITransferringService
    {
        private readonly ITransferringRepository _repository;
        private readonly ITransferringTokenGenerator _tokenGenerator;
        private readonly ITransferringIdProvider _idProvider;
        private readonly IEventHandlersMediator _eventHandlersMediator;

        public TransferringService(
            ITransferringRepository repository,
            ITransferringTokenGenerator tokenGenerator,
            ITransferringIdProvider idProvider,
            IEventHandlersMediator eventHandlersMediator)
        {
            _repository = repository;
            _tokenGenerator = tokenGenerator;
            _idProvider = idProvider;
            _eventHandlersMediator = eventHandlersMediator;
        }

        public async Task<RegistrationResultDto> Register(RegistrationDto registration)
        {
            var fileDescriptions = registration
                .FileDescriptions
                .Select(dto => new FileDescription(new FileId(dto.Id.Value), dto.PhysicalPath, dto.Size))
                .ToList();

            var transferring = new Transferring(
                _idProvider.GetFreeId(),
                registration.TransferringType,
                fileDescriptions,
                _tokenGenerator.Generate(),
                new UserId(registration.UserId.Value));

            _repository.Add(transferring);

            var eventDto = new TransferringDto(
                new TransferringIdDto() { Value = transferring.Id.Value },
                new TransferringTokenDto() { Value = transferring.Token.Value },
                transferring.Type,
                registration.FileDescriptions);

            await _eventHandlersMediator.Publish(new TransferringRegisteredEvent(eventDto));

            return new RegistrationResultDto(new TransferringIdDto() { Value = transferring.Id.Value });
        }
    }
}
