﻿using System;
using System.Linq.Expressions;

namespace Bddify.Scanners.StepScanners.Fluent
{
    public interface IGiven<TScenario>
    {
        IWhen<TScenario> When(Expression<Action<TScenario>> whenStep, string stepTextTemplate = null);
        IAndGiven<TScenario> And(Expression<Action<TScenario>> andGivenStep, string stepTextTemplate = null);
        IThen<TScenario> Then(Expression<Action<TScenario>> thenStep, string stepTextTemplate = null);
#if NET35
        IWhen<TScenario> When(Expression<Action<TScenario>> whenStep);
        IAndGiven<TScenario> And(Expression<Action<TScenario>> andGivenStep);
        IThen<TScenario> Then(Expression<Action<TScenario>> thenStep);
#endif
    }
}