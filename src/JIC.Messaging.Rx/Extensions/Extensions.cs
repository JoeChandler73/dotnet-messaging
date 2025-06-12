using JIC.Messaging.Handlers;
using JIC.Messaging.Messaging;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace JIC.Messaging.Rx.Extensions;

public static class Extensions
{
    public static IHostBuilder Configure(this IHostBuilder hostBuilder)
    {
        hostBuilder
            .ConfigureServices((builder, services) =>
            {
                services.AddSingleton<IMessageHandler<TestMessage>, TestMessageHandler>();
                
                services.AddSingleton<IMessageBroker>(provider =>
                {
                    var messageBroker = new RxMessageBroker();
                    messageBroker.Subscribe(provider.GetRequiredService<IMessageHandler<TestMessage>>());
                    return messageBroker;
                });

                services.AddSingleton<IMessageConsumer, FakeMessageConsumer>();
                services.AddHostedService<MessageService>();
            });

        return hostBuilder;
    }
}