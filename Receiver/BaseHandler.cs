using Messages;

namespace Receiver;

public abstract class BaseHandler<TJob, TJobParams> : IHandleMessages<QueueJob<TJobParams>>
    where TJob : class
    where TJobParams : class, IJobParameters, new()
{
    public virtual Task Handle(QueueJob<TJobParams> message, IMessageHandlerContext context)
    {
        Console.WriteLine($"Base Received message: {message.Parameters}");
        return Task.CompletedTask;
    }
}
