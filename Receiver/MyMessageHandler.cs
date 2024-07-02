using Messages;

namespace Receiver;

public sealed class MyMessageHandler : BaseHandler<DummyJob, TriggerProcessorJobParams>
{
    public override async Task Handle(QueueJob<TriggerProcessorJobParams> message, IMessageHandlerContext context)
    {
        await base.Handle(message, context);
        
        Console.WriteLine($"MyMessage Received message: Processor ID => {message.Parameters.ProcessorId}");
    }
}