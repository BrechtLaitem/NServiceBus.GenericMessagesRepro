// See https://aka.ms/new-console-template for more information

using Messages;

var endpointConfiguration = new EndpointConfiguration("Sender");
endpointConfiguration.UseTransport<LearningTransport>();
endpointConfiguration.UseSerialization<SystemJsonSerializer>();
endpointConfiguration.SendOnly();

var endpoint = await Endpoint.Start(endpointConfiguration);

var rnd = new Random(69);

while (true)
{
    await endpoint.Send("Receiver", new QueueTriggerProcessorJob 
    { 
        Parameters = new TriggerProcessorJobParams 
        { 
            ProcessorId = rnd.Next() 
        } 
    });
    Console.WriteLine("Message sent. Press Enter to send another message.");
    Console.ReadLine();
}

await endpoint.Stop();

