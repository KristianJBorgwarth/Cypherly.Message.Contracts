using Cypherly.Message.Contracts.Abstractions;
using Cypherly.Message.Contracts.Enums;

namespace Cypherly.Message.Contracts.Messages.Common;

public sealed record OperationSucceededMessage : IBaseMessage
{
    public DateTime OccurredOn { get;} = DateTime.UtcNow;
    public Guid Id { get; } = Guid.NewGuid();
    public required Guid CorrelationId { get; init; }
    public Guid? CausationId { get; init; } = null;
    public required OperationType OperationType { get; init; }
}