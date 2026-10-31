using Cendrite.Message.Contracts.Abstractions;

namespace Cendrite.Message.Contracts.Messages.Client;

public sealed record ClientConnectedMessage : IBaseMessage
{
    public DateTime OccurredOn { get;} = DateTime.UtcNow;
    public Guid Id { get; } = Guid.NewGuid();
    public required Guid CorrelationId { get; init; }
    public Guid? CausationId { get; init; }  = null;
    public required Guid DeviceId { get; init; }
}