using Messages;

namespace Receiver;

public class BaseHandler<TJob> : IHandleMessages<QueueJob<TJob>>
{
    public virtual Task Handle(QueueJob<TJob> message, IMessageHandlerContext context)
    {
        Console.WriteLine($"Base Received message: {message.Data}");
        return Task.CompletedTask;
    }
}