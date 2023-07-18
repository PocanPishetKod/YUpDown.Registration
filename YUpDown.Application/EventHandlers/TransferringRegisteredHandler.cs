using YHome.MessageBroker.Interface;
using YUpDown.Registration.Application.Events;

namespace YUpDown.Registration.Application.EventHandlers
{
    public class TransferringRegisteredHandler : BrockerHandler<TransferringRegisteredEvent>, IAsyncEventHandler<TransferringRegisteredEvent>
    {
        public TransferringRegisteredHandler(IBroker broker)
            : base(broker) { }

        public async Task Handle(TransferringRegisteredEvent @event)
        {
            await SendMessage(@event);
        }
    }
}
