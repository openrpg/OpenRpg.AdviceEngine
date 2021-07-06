using OpenRpg.AdviceEngine.Keys;
using OpenRpg.AdviceEngine.Variables;
using OpenRpg.Core.Common;
using OpenRpg.CurveFunctions;

namespace OpenRpg.AdviceEngine.Considerations
{
    public class UtilityBasedConsideration : IUtilityBasedConsideration
    {
        public UtilityKey UtilityId { get; }
        public UtilityKey DependentUtilityId { get; }
        public ICurveFunction Evaluator { get; }

        public UtilityBasedConsideration(UtilityKey utilityId, UtilityKey dependentUtilityId, ICurveFunction evaluator = null)
        {
            DependentUtilityId = dependentUtilityId;
            UtilityId = utilityId;
            Evaluator = evaluator;
        }

        public float CalculateUtility(IHasDataId ownerContext, IUtilityVariables utilityVariables)
        {
            var existingUtility = utilityVariables[DependentUtilityId];
            if (Evaluator == null) { return existingUtility; }
            return Evaluator.Plot(existingUtility);
        }
    }
}