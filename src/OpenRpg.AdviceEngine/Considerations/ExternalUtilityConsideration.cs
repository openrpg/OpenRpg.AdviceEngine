using System;
using OpenRpg.AdviceEngine.Keys;
using OpenRpg.AdviceEngine.Variables;
using OpenRpg.CurveFunctions;

namespace OpenRpg.AdviceEngine.Considerations
{
    public class ExternalUtilityBasedConsideration : UtilityBasedConsideration
    {
        public Func<IUtilityVariables> ExternalVariableAccessor { get; }

        public ExternalUtilityBasedConsideration(UtilityKey utilityId, UtilityKey dependentUtilityId, Func<IUtilityVariables> externalVariableAccessor, ICurveFunction evaluator = null) : base(utilityId, dependentUtilityId, evaluator)
        { ExternalVariableAccessor = externalVariableAccessor; }
    }
}