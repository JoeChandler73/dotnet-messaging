using JIC.Messaging.Messages;
using JIC.Messaging.Serialization;

namespace JIC.Messaging;

public abstract class MessageProducer(IMessageSerializer serializer) 
    : IMessageProducer
{
    public Task ProduceAsync<T>(T message) where T : IMessage
    {
        var messageBytes = serializer.Serialize(message);
        
        return ProduceBytesAsync(messageBytes);
    }
    
    protected abstract Task ProduceBytesAsync(byte[] messageBytes);
}