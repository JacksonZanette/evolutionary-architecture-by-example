namespace EvolutionaryArchitecture.Fitnet.Common.Api.ErrorHandling;

using System;

public sealed class ResourceNotFoundException(Guid id) : InvalidOperationException($"Resource with '{id}' not found ")
{
}
