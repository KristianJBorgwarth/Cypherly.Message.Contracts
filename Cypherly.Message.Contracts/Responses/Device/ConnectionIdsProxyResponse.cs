using Cypherly.Message.Contracts.Abstractions;

namespace Cypherly.Message.Contracts.Responses.Device
{
    public class ConnectionIdsProxyResponse : IBaseMessage
    {
        public Guid Id { get; } = Guid.NewGuid();
        public DateTime OccurredOn { get; } = DateTime.UtcNow;
        public required Guid CorrelationId { get; init; }
        public Guid? CausationId { get; init; } = null;
        public bool IsSuccess { get; init; } = true;
        public string? Error { get; init; } = null;
        public required string UserTag { get; init; } 
        public Dictionary<Guid, List<Guid>>? ConnectionIds { get; init; } = null;
    }
}
