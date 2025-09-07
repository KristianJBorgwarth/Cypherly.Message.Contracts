namespace Cypherly.Message.Contracts.Messages.Device;

public class ConnectionIdsMessage
{
    public DateTime OccurredOn { get;} = DateTime.UtcNow;
    public Guid Id { get; } = Guid.NewGuid();
    public required Guid CorrelationId { get; init; }
    public Guid? CausationId { get; init; }  = null;
    public required IReadOnlyCollection<Guid> TenantIds { get; init; }
}