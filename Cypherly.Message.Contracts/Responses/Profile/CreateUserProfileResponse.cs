using Cypherly.Message.Contracts.Abstractions;

namespace Cypherly.Message.Contracts.Responses.Profile;

public sealed record CreateUserProfileResponse : IResponse
{
    public DateTime OccurredOn { get; init; }
    public Guid Id { get; init; }
    public Guid CorrelationId { get; init; }
    public Guid? CausationId { get; init; }
    public bool IsSuccess { get; init; }
    public string? Error { get; init; }
}