using Cypherly.Message.Contracts.Abstractions;

namespace Cypherly.Message.Contracts.Messages.Email;

public sealed class SendEmailMessage : IBaseMessage
{
    public DateTime OccurredOn { get;} = DateTime.UtcNow;
    public Guid Id { get; } = Guid.NewGuid();
    public required Guid CorrelationId { get; init; }
    public Guid? CausationId { get; init; } = null;
    public required string To { get; init; }
    public required string Subject { get; init; }
    public required string Body { get; init; }
}