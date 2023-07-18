namespace YUpDown.Registration.Application.Events
{
    public interface IAsyncEventHandler<TEvent>
    {
        Task Handle(TEvent @event);
    }
}
