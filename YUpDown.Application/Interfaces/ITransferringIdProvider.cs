using YUpDown.Registration.Domain.Transferings;

namespace YUpDown.Registration.Application.Interfaces
{
    public interface ITransferringIdProvider
    {
        TransferringId GetFreeId();
    }
}
