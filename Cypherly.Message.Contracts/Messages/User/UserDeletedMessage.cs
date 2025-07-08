using Cypherly.Message.Contracts.Abstractions;

namespace Cypherly.Message.Contracts.Messages.User;

public sealed record UserDeletedMessage : IBaseMessage
{
    public required DateTime OccurredOn { get; init; }
    public required Guid Id { get; init; }
    public required Guid CorrelationId { get; init; }
    public required Guid? CausationId { get; init; }
    public required Guid UserId { get; init; }
    public required string Email { get; init; }
}