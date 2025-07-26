using Cypherly.Message.Contracts.Abstractions;

namespace Cypherly.Message.Contracts.Messages.Friendship;

public sealed record FriendshipAcceptedMessage : IBaseMessage
{
    public DateTime OccurredOn { get;} = DateTime.UtcNow;
    public Guid Id { get; } = Guid.NewGuid();
    public required Guid CorrelationId { get; init; }
    public Guid? CausationId { get; init; } = null;
    public required string Username { get; init; }
    public required string Tag { get; init; }
    public string? DisplayName { get; init; }
    public string? ProfilePictureUrl { get; init; }
    public required IReadOnlyCollection<Guid> RouteIds { get; init; }
    public required IReadOnlyCollection<Guid> ConnectionIds { get; init; }
}