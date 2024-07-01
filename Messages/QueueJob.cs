namespace Messages;

public class QueueJob<T> : IMessage
{
    public T Data { get; set; }
}