using Cypherly.Message.Contracts.Abstractions;

namespace Cypherly.Message.Contracts.Messages.Device
{
    public sealed class ConnectionIdsProxyMessage : IBaseMessage
    {
        public Guid Id { get; } = Guid.NewGuid();
        public DateTime OccurredOn { get; } = DateTime.UtcNow;
        public Guid CorrelationId { get; init; }
        public Guid? CausationId { get; init; }
        public required Guid TenantId { get; init; }
    }
}
