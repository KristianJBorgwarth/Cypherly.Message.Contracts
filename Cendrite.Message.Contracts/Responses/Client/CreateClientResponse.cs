using Cendrite.Message.Contracts.Abstractions;

namespace Cendrite.Message.Contracts.Responses.Client;

public sealed record CreateClientResponse : IResponse
{
    public DateTime OccurredOn { get;} = DateTime.UtcNow;
    public Guid Id { get; } = Guid.NewGuid();
    public required Guid CorrelationId { get; init; }
    public Guid? CausationId { get; init; }  = null;
    public bool IsSuccess { get; init; } = true;
    public string? Error { get; init; } 
}