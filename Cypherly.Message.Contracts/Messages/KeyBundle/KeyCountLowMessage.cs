using Cypherly.Message.Contracts.Abstractions;

namespace Cypherly.Message.Contracts.Messages.KeyBundle;

public class KeyCountLowMessage : IBaseMessage
{
    public Guid Id { get; }  = Guid.NewGuid();
    public DateTime OccurredOn { get; }  = DateTime.UtcNow;
    public required Guid CorrelationId { get; init; }
    public Guid? CausationId { get; init; }
    public required Guid TenantId { get; init; }
    public required Guid ConnectionId { get; init; }
}