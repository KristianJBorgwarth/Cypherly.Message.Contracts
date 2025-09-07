using Cypherly.Message.Contracts.Abstractions;

namespace Cypherly.Message.Contracts.Responses.Device;

public class ConnectionIdResponse : IBaseMessage
{
    public DateTime OccurredOn { get;} = DateTime.UtcNow;
    public Guid Id { get; } = Guid.NewGuid();
    public required Guid CorrelationId { get; init; }
    public Guid? CausationId { get; init; }  = null;
    public bool IsSuccess { get; init; } = true;
    public string? Error { get; init; }
    public IReadOnlyCollection<Guid> ConnectionIds { get; init; } = [];
}