namespace YUpDown.Registration.Application.Dtos
{
    public class RegistrationResultDto
    {
        public TransferringIdDto TransferingId { get; }

        public RegistrationResultDto(TransferringIdDto transferingId)
        {
            TransferingId = transferingId;
        }
    }
}
