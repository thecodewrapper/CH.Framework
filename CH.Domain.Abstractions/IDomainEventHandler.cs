namespace CH.Domain.Abstractions
{
    public interface IDomainEventHandler<T> where T : IDomainEvent
    {
        void Apply(T @event);
    }
}
