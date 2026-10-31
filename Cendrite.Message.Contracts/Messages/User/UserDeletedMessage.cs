using Cendrite.Message.Contracts.Abstractions;

namespace Cendrite.Message.Contracts.Messages.User;

public sealed record UserDeletedMessage : IBaseMessage
{
    public DateTime OccurredOn { get;} = DateTime.UtcNow;
    public Guid Id { get; } = Guid.NewGuid();
    public required Guid CorrelationId { get; init; }
    public Guid? CausationId { get; init; }  = null;
    public required Guid UserId { get; init; }
    public required string Email { get; init; }
}