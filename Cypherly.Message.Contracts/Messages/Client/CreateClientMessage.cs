
using Cypherly.Message.Contracts.Abstractions;

namespace Cypherly.Message.Contracts.Messages.Client;

public sealed record CreateClientMessage : IBaseMessage
{
    public DateTime OccurredOn { get; init; }
    public Guid Id { get; init; }
    public Guid CorrelationId { get; init; }
    public Guid? CausationId { get; init; }
    public required Guid DeviceId { get; init; }
    public required Guid ConnectionId { get; init; }
}