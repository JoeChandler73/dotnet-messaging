using JIC.Messaging.Messages;

namespace JIC.Messaging.Handlers;

public abstract class MessageHandler<T> : IMessageHandler<T> where T : IMessage
{
    public abstract Task HandleAsync(T message);
    
    public Task HandleAsync(IMessage message)
    {
        return HandleAsync((T)message);
    }
}