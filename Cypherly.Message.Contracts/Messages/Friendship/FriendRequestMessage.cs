using Cypherly.Message.Contracts.Abstractions;

namespace Cypherly.Message.Contracts.Messages.Friendship;

public sealed record FriendRequestMessage : IBaseMessage
{
    public DateTime OccurredOn { get;} = DateTime.UtcNow;
    public Guid Id { get; init; } = Guid.NewGuid();
    public required Guid CorrelationId { get; init; }
    public required Guid? CausationId { get; init; }
    public required Guid UserId { get; init; }
    public required IReadOnlyCollection<Guid> ConnectionIds { get; init; }
    public required string FriendTag { get; init; }
    public required DateTime FriendRequestDate { get; init; }
    public required bool IsSeen { get; init; }
    public string? FriendDisplayName { get; init; }
    public string? FriendProfilePictureUrl { get; init; }
    public required string FriendUsername { get; init; }
}