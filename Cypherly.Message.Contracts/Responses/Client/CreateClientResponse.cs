using Cypherly.Message.Contracts.Abstractions;

namespace Cypherly.Message.Contracts.Responses.Client;

public sealed record CreateClientResponse : IResponse
{
    public DateTime OccurredOn { get;} = DateTime.UtcNow;
    public Guid Id { get; } = Guid.NewGuid();
    public Guid CorrelationId { get; init; }
    public Guid? CausationId { get; init; }
    public bool IsSuccess { get; init; }
    public string? Error { get; init; }
}