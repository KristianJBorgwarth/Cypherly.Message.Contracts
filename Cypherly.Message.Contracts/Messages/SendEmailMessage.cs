using Cypherly.Message.Contracts.Abstractions;

namespace Cypherly.Message.Contracts.Messages;

/// <summary>
/// Represents a message to send an email.
/// Contains the necessary information such as recipient, subject, and body.
/// </summary>
public sealed class SendEmailMessage : IBaseMessage
{
    public required DateTime OccurredOn { get; init; }
    public required Guid Id { get; init; }
    public required Guid CorrelationId { get; init; }
    public required Guid? CausationId { get; init; }
    public required string To { get; init; }
    public required string Subject { get; init; }
    public required string Body { get; init; }
}