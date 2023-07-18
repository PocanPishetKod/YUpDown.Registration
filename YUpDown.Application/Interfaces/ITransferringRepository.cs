using YUpDown.Registration.Domain.Transferings;

namespace YUpDown.Registration.Application.Interfaces
{
    public interface ITransferringRepository
    {
        void Add(Transferring transferring);

        void Remove(TransferringId id);
    }
}
