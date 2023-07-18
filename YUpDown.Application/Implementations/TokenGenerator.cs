using YUpDown.Registration.Application.Interfaces;
using YUpDown.Registration.Domain.Transferings;

namespace YUpDown.Registration.Application.Implementations
{
    public class TokenGenerator : ITransferringTokenGenerator
    {
        public TransferringToken Generate()
        {
            return new TransferringToken("ajsdflkjangjksdnglkjsdng");
        }
    }
}
