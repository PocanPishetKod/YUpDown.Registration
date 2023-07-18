namespace YUpDown.Registration.Application.Interfaces
{
    public interface IEventHandlersMediator
    {
        Task Publish<TEvent>(TEvent @event);
    }
}
