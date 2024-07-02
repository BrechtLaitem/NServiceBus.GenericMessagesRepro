namespace Messages;

public sealed class TriggerProcessorJobParams : IJobParameters
{
    public int ProcessorId { get; set; }

    public string GetDashboardDescription() => $"Trigger processor '{ProcessorId}'";
}