namespace EvolutionaryArchitecture.Fitnet.Contracts.IntegrationEvents;

using Common.Infrastructure.Events;

public record ContractSignedEvent(
    Guid Id,
    Guid ContractId,
    Guid ContractCustomerId,
    DateTimeOffset SignedAt,
    DateTimeOffset ExpireAt,
    DateTimeOffset OccurredDateTime) : IIntegrationEvent
{
    public static ContractSignedEvent Create(
        Guid contractId,
        Guid contractCustomerId,
        DateTimeOffset signedAt,
        DateTimeOffset expireAt,
        DateTimeOffset occurredAt) =>
        new(Guid.NewGuid(), contractId, contractCustomerId, signedAt, expireAt, occurredAt);
}

