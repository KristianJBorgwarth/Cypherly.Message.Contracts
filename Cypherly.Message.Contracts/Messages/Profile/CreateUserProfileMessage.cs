using Cypherly.Message.Contracts.Abstractions;

namespace Cypherly.Message.Contracts.Messages.Profile;

public sealed class CreateUserProfileMessage : IBaseMessage
{
    public DateTime OccurredOn { get; init; }
    public Guid Id { get; init; }
    public Guid CorrelationId { get; init; }
    public Guid? CausationId { get; init; }
    public required Guid UserId { get; init; }
    public required string Username { get; init; }
}