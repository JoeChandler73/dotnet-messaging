using JIC.Messaging.Messages;

namespace JIC.Messaging.Handlers;

public interface IMessageHandler
{
    Task HandleAsync(IMessage message);
}

public interface IMessageHandler<in T> : IMessageHandler where T : IMessage
{
    Task HandleAsync(T message);
}