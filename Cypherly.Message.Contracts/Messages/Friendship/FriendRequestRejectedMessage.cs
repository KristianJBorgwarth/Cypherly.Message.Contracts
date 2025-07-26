using Cypherly.Message.Contracts.Abstractions;

namespace Cypherly.Message.Contracts.Messages.Friendship;

public sealed record FriendRequestRejectedMessage : IBaseMessage
{
    public DateTime OccurredOn { get; } = DateTime.UtcNow;
    public Guid Id { get; } = Guid.NewGuid();
    public required Guid CorrelationId { get; init; }
    public Guid? CausationId { get; init; } = null;
    public required string RejectedUserProfileTag { get; init; }
    public required IReadOnlyCollection<Guid> ConnectionIds { get; init; }
}