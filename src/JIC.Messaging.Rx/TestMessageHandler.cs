using JIC.Messaging.Handlers;
using Microsoft.Extensions.Logging;

namespace JIC.Messaging.Rx;

public class TestMessageHandler(ILogger<TestMessageHandler> logger) : MessageHandler<TestMessage>
{
    public override Task HandleAsync(TestMessage message)
    {
        logger.LogInformation("Received TestMessage with text: {0}, timestamp: {1}", message.Text, message.When);
        
        return Task.CompletedTask;
    }
}