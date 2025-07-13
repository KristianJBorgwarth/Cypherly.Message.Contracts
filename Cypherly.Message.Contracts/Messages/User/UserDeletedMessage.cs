using Cypherly.Message.Contracts.Abstractions;

namespace Cypherly.Message.Contracts.Messages.User;

public sealed record UserDeletedMessage : IBaseMessage
{
    public DateTime OccurredOn { get;} = DateTime.UtcNow;
    public Guid Id { get; init; } = Guid.NewGuid();
    public required Guid CorrelationId { get; init; }
    public required Guid? CausationId { get; init; }
    public required Guid UserId { get; init; }
    public required string Email { get; init; }
}