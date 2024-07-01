// See https://aka.ms/new-console-template for more information

using NServiceBus.Logging;

LogManager.Use<DefaultFactory>()
    .Level(LogLevel.Debug);

var endpointConfiguration = new EndpointConfiguration("Receiver");
endpointConfiguration.UseTransport<LearningTransport>();
endpointConfiguration.UseSerialization<SystemJsonSerializer>();

var endpoint = await Endpoint.Start(endpointConfiguration);

Console.ReadLine();

await endpoint.Stop();