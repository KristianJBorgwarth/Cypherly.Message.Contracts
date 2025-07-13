namespace Cypherly.Message.Contracts.Abstractions;

public interface IProducer<in TMessage> where TMessage : IBaseMessage
{
    Task PublishMessageAsync(TMessage message, CancellationToken cancellationToken = default);
}