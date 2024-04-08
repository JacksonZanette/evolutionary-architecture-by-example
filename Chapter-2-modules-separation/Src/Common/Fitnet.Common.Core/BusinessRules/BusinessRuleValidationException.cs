namespace EvolutionaryArchitecture.Fitnet.Common.Core.BusinessRules;

using System;

public class BusinessRuleValidationException(string message) : InvalidOperationException(message)
{
}
