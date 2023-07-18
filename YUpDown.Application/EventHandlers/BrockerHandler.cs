using YHome.MessageBroker.Interface;

namespace YUpDown.Registration.Application.EventHandlers
{
    public abstract class BrockerHandler<TEvent>
    {
        private readonly IBroker _broker;

        public BrockerHandler(IBroker broker)
        {
            _broker = broker;
        }

        protected async Task SendMessage(TEvent @event)
        {
            await _broker
                .GetMessageChannel(typeof(TEvent).Name)
                .SendMessage(@event);
        }
    }
}
