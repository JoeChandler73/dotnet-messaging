namespace JIC.Messaging.Messages;

public abstract record Message : IMessage
{
    public DateTime When { get; init; } = DateTime.UtcNow;
}