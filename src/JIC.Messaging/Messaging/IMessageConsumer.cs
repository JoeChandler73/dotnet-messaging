using JIC.Messaging.Handlers;

namespace JIC.Messaging.Messaging;

public interface IMessageConsumer
{
    Task StartAsync(IMessageHandler messageHandler, CancellationToken stoppingToken = default);
}