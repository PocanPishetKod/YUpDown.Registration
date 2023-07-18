using System.Reflection;
using YUpDown.Registration.Application.Events;
using YUpDown.Registration.Application.Interfaces;

namespace YUpDown.Registration.Application.EventHandlers
{
    public class EventHandlersMediator : IEventHandlersMediator
    {
        private readonly IServiceProvider _serviceProvider;

        public EventHandlersMediator(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task Publish<TEvent>(TEvent @event)
        {
            await GetHandler<TEvent>().Handle(@event);
        }

        private IAsyncEventHandler<TEvent> GetHandler<TEvent>()
        {
            var handler = _serviceProvider.GetService(typeof(IAsyncEventHandler<TEvent>));

            if (handler == null)
                throw new InvalidOperationException($"Handler type {typeof(IAsyncEventHandler<TEvent>).FullName} not registered.");

            return (handler as IAsyncEventHandler<TEvent>)!;
        }

        private Type? GetHandlerType<TEvent>()
        {
            return Assembly
                .GetAssembly(typeof(TEvent))
                !.DefinedTypes
                .Where(t => t.ImplementedInterfaces.Any(i => i == typeof(IAsyncEventHandler<TEvent>)))
                .SingleOrDefault();
        }
    }
}
