using Messages;

namespace Receiver;

public class MyMessageHandler : BaseHandler<TriggerProcessorJobParams>
{
    public override async Task Handle(QueueJob<TriggerProcessorJobParams> message, IMessageHandlerContext context)
    {
        await base.Handle(message, context);
        
        Console.WriteLine($"MyMessage Received message: {message.Data.Content}");
    }
}