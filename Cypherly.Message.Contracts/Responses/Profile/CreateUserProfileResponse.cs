using Cypherly.Message.Contracts.Abstractions;

namespace Cypherly.Message.Contracts.Responses.Profile;

public sealed record CreateUserProfileResponse : IResponse
{
    public DateTime OccurredOn { get;} = DateTime.UtcNow;
    public Guid Id { get; } = Guid.NewGuid();
    public required Guid CorrelationId { get; init; }
    public Guid? CausationId { get; init; }  = null;
    public bool IsSuccess { get; init; } = true;
    public string? Error { get; init; } = null;
}