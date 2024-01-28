namespace CH.Messaging.Abstractions
{
    /// <summary>
    /// Abstraction over a request/message to be send to a message broker
    /// Should implement any interfaces to comply with any given message brokers request object (if any)
    /// </summary>
    /// <typeparam name="TResponse"></typeparam>
    public interface IRequest<TResponse> : IRequest where TResponse : class
    {
    }

    /// <summary>
    /// Abstraction over a request/message to be send to a message broker
    /// Should implement any interfaces to comply with any given message brokers request object (if any)
    /// </summary>
    public interface IRequest
    {
    }
}