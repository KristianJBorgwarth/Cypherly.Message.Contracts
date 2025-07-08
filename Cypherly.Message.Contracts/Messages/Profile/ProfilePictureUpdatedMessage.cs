using Cypherly.Message.Contracts.Abstractions;

namespace Cypherly.Message.Contracts.Messages.Profile;

public sealed class ProfilePictureUpdatedMessage : IBaseMessage
{
    public required DateTime OccurredOn { get; init; }
    public required Guid Id { get; init; }
    public required Guid CorrelationId { get; init; }
    public required Guid? CausationId { get; init; }
    public required string UserTag { get; init; }
    public required string ProfilePictureUrl { get; init; }
    public required IReadOnlyCollection<Guid> ConnectionIds { get; init; }
}