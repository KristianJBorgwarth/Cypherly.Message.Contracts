namespace Cypherly.Message.Contracts.Abstractions;

/// <summary>
/// Abstraction for a message producer.
/// </summary>
/// <typeparam name="TMessage"></typeparam>
public interface IProducer<in TMessage> where TMessage : IBaseMessage
{
    Task PublishMessageAsync(TMessage message, CancellationToken cancellationToken = default);
}