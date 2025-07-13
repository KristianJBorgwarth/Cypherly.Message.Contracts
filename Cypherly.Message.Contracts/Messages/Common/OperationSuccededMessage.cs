using Cypherly.Message.Contracts.Abstractions;
using Cypherly.Message.Contracts.Enums;

namespace Cypherly.Message.Contracts.Messages.Common;

public sealed record OperationSuccededMessage : IBaseMessage
{
    public DateTime OccurredOn { get;} = DateTime.UtcNow;
    public Guid Id { get; init; } = Guid.NewGuid();
    public Guid CorrelationId { get; init; }
    public Guid? CausationId { get; init; }
    public required OperationType OperationType { get; init; }
}