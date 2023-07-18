using YUpDown.Registration.Application.Interfaces;

namespace YUpDown.Registration.Domain.Transferings
{
    public class DefaultTransferingIdProvider : ITransferringIdProvider
    {
        public DefaultTransferingIdProvider() { }

        public TransferringId GetFreeId()
        {
            return new TransferringId(Guid.NewGuid());
        }
    }
}
