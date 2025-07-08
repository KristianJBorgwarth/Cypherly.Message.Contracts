using Cypherly.Message.Contracts.Abstractions;
using Cypherly.Message.Contracts.Enums;

namespace Cypherly.Message.Contracts.Messages.User;

public sealed record UserDeleteFailedMessage : IBaseMessage
{
    public required DateTime OccurredOn { get; init; }
    public required Guid Id { get; init; }
    public required Guid CorrelationId { get; init; }
    public required Guid? CausationId { get; init; }
    public required Guid UserId { get; init; }
    public required ServiceType[] Services { get; init; }

    public bool ContainsService(ServiceType serviceType)
    {
        return Services.Contains(serviceType);
    }
}