using Cypherly.Message.Contracts.Abstractions;

namespace Cypherly.Message.Contracts.Messages.UserProfile;

public sealed class ProfilePictureUpdatedMessage : IBaseMessage
{
    public required DateTime OccurredOn { get; init; }
    public required Guid Id { get; init; }
    public required Guid CorrelationId { get; init; }
    public required Guid? CausationId { get; init; }
}