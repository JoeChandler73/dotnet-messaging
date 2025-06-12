using JIC.Messaging.Rx.Extensions;
using Microsoft.Extensions.Hosting;

var hostBuilder = Host.CreateDefaultBuilder(args)
   .Configure();

await hostBuilder.RunConsoleAsync();



