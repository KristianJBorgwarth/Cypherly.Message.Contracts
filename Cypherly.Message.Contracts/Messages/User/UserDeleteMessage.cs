using Cypherly.Message.Contracts.Abstractions;

namespace Cypherly.Message.Contracts.Messages.User;

public class UserDeleteMessage : IBaseMessage
{
    public DateTime OccurredOn { get;} = DateTime.UtcNow;
    public Guid Id { get; } = Guid.NewGuid();
    public required Guid CorrelationId { get; init; }
    public Guid? CausationId { get; init; } = null;
    public required Guid UserProfileId { get; init; }
}