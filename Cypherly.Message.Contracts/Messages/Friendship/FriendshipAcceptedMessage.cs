using Cypherly.Message.Contracts.Abstractions;

namespace Cypherly.Message.Contracts.Messages.Friendship;

public sealed record FriendshipAcceptedMessage : IBaseMessage
{
    public required DateTime OccurredOn { get; init; }
    public required Guid Id { get; init; }
    public required Guid CorrelationId { get; init; }
    public required Guid? CausationId { get; init; }
    public required string RejectedUserProfileTag { get; init; }
    public required IReadOnlyCollection<Guid> ConnectionIds { get; init; }
}