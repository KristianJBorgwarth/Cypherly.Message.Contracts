namespace Cypherly.Message.Contracts.Abstractions;

/// <summary>
/// Base interface for all messages in the system.
/// </summary>
internal interface IBaseMessage
{
    /// <summary>
    /// The time that the message was created.
    /// </summary>
    public DateTime OccurredOn { get; init; }

    /// <summary>
    /// The unique identifier for this message.
    /// </summary>
    public Guid Id { get; init; }

    /// <summary>
    /// Should be the same for all messages that are part of the same logical operation.
    /// Set by the originating message.
    /// </summary>
    public Guid CorrelationId { get; init; }

    /// <summary>
    /// Should match the ID of the message that caused this message to be created.
    /// Will be null for the first message in a chain.
    /// </summary>
    public Guid? CausationId { get; init; }
}