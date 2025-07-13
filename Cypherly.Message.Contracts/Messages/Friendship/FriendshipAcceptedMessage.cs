using Cypherly.Message.Contracts.Abstractions;

namespace Cypherly.Message.Contracts.Messages.Friendship;

public sealed record FriendshipAcceptedMessage : IBaseMessage
{
    public DateTime OccurredOn { get;} = DateTime.UtcNow;
    public Guid Id { get; init; } = Guid.NewGuid();
    public required Guid CorrelationId { get; init; }
    public required Guid? CausationId { get; init; }
    public required string RejectedUserProfileTag { get; init; }
    public required IReadOnlyCollection<Guid> ConnectionIds { get; init; }
    public required IReadOnlyCollection<Guid> RouteIds { get; init; }
}