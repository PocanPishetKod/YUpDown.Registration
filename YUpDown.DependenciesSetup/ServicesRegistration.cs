using Microsoft.Extensions.DependencyInjection;
using YUpDown.Registration.Data;
using YHome.MessageBroker.Interface;
using YHome.MessageBroker.RabbitMQ;
using YUpDown.Common;
using YUpDown.Registration.Application.EventHandlers;
using YUpDown.Registration.Application.Events;
using YUpDown.Registration.Application.Implementations;
using YUpDown.Registration.Application.Interfaces;
using YUpDown.Registration.Application.Services;
using YUpDown.Registration.Domain.Transferings;
using YUpDown.Registration.Messaging.Brocker;

namespace YUpDown.DependenciesSetup
{
    public static class ServicesRegistration
    {
        public static IServiceCollection AddApplication(this IServiceCollection services, Configuration configuration)
        {
            return services
                .AddAppIntefaces()
                .AddBrockerHandlers(configuration);
        }

        private static IServiceCollection AddAppIntefaces(this IServiceCollection services)
        {
            return services.AddSingleton<ITransferringRepository>(new TransferringRepository())
                .AddSingleton<ITransferringTokenGenerator, TokenGenerator>()
                .AddSingleton<ITransferringIdProvider, DefaultTransferingIdProvider>()
                .AddSingleton<IEventHandlersMediator, EventHandlersMediator>()
                .AddSingleton<ITransferringService, TransferringService>();
        }

        private static IServiceCollection AddBrockerHandlers(this IServiceCollection services, Configuration configuration)
        {
            var brocker = new Rabbitmq(
                new BrokerSettings(configuration.RabbitHost, configuration.QueueNames.Select(n => new ChannelDescription(n, false))));

            return services.AddSingleton<IBroker>(brocker)
                .AddSingleton<IAsyncEventHandler<TransferringRegisteredEvent>, TransferringRegisteredHandler>();
        }
    }
}