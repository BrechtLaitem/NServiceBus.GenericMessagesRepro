namespace Messages;

public abstract class QueueJob<TJobParams> : IMessage where TJobParams : IJobParameters
{
    public TJobParams Parameters { get; set; } = default!;
}