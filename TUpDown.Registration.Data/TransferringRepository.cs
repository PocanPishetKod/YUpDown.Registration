using YUpDown.Registration.Application.Interfaces;
using YUpDown.Registration.Domain.Transferings;

namespace TUpDown.Registration.Store
{
    public class TransferringRepository : ITransferringRepository
    {
        private readonly List<Transferring> _transferrings;

        public TransferringRepository()
        {
            _transferrings = new List<Transferring>();
        }

        public void Add(Transferring transferring)
        {
            _transferrings.Add(transferring);
        }

        public void Remove(TransferringId id)
        {
            var transferring = _transferrings.Find(x => x.Id == id);

            if (transferring == null)
                throw new InvalidOperationException("Transferring not found.");

            _transferrings.Remove(transferring);
        }
    }
}
