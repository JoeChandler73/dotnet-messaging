using JIC.Messaging.Messages;

namespace JIC.Messaging;

public interface IMessageProducer
{
    Task ProduceAsync<T>(T message) where T : IMessage;
}