﻿using System.Threading.Tasks;

namespace CH.Messaging.Abstractions
{
    /// <summary>
    /// Abstraction over a handler of messages coming from a message broker.
    /// Should implement any interfaces to comply with any given message brokers handler object
    /// </summary>
    /// <typeparam name="TRequest"></typeparam>
    /// <typeparam name="TResponse"></typeparam>
    public interface IHandler<TRequest, TResponse>
        where TRequest : class, IRequest<TResponse>
        where TResponse : class
    {
        Task<TResponse> HandleAsync(TRequest request);
    }

    /// <summary>
    /// Abstraction over a handler of messages coming from a message broker.
    /// Should implement any interfaces to comply with any given message brokers handler object
    /// </summary>
    /// <typeparam name="TRequest"></typeparam>
    public interface IHandler<TRequest> where TRequest : class, IRequest
    {
        Task HandleAsync(TRequest request);
    }
}