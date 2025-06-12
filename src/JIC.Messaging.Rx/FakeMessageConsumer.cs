using JIC.Messaging.Handlers;
using JIC.Messaging.Messaging;

namespace JIC.Messaging.Rx;

public class FakeMessageConsumer : IMessageConsumer
{
    public async Task StartAsync(IMessageHandler messageHandler, CancellationToken stoppingToken = default)
    {
        var count = 0;
        while (!stoppingToken.IsCancellationRequested)
        {
            await Task.Delay(1000, stoppingToken);
            
            var message = new TestMessage($"Hello {++count}");
            
            await messageHandler.HandleAsync(message);
        }
    }
}