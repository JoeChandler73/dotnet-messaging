using JIC.Messaging.Messages;

namespace JIC.Messaging.Serialization;

public interface IMessageSerializer
{
    byte[] Serialize<T>(T message) where T : IMessage;
    
    T Deserialize<T>(byte[] bytes) where T : IMessage;
}