using JIC.Messaging.Handlers;
using JIC.Messaging.Messaging;
using Microsoft.Extensions.Hosting;

namespace JIC.Messaging.Rx;

public class MessageService(
    IMessageConsumer _messageConsumer,
    IMessageBroker _messageBroker) : BackgroundService
{
    protected override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        return _messageConsumer.StartAsync(_messageBroker, stoppingToken);
    }
}