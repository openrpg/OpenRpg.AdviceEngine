using OpenRpg.AdviceEngine.Accessors;
using OpenRpg.AdviceEngine.Clampers;
using OpenRpg.AdviceEngine.Keys;
using OpenRpg.AdviceEngine.Variables;
using OpenRpg.Core.Common;
using OpenRpg.CurveFunctions;

namespace OpenRpg.AdviceEngine.Considerations
{
    public class ValueBasedConsideration : IValueBasedConsideration
    {
        public UtilityKey UtilityId { get; }
        public IValueAccessor ValueAccessor { get; }
        public IClamper Clamper { get; }
        public ICurveFunction Evaluator { get; }

        public ValueBasedConsideration(UtilityKey utilityId, IValueAccessor valueAccessor, IClamper clamper, ICurveFunction evaluator)
        {
            ValueAccessor = valueAccessor;
            Clamper = clamper;
            Evaluator = evaluator;
            UtilityId = utilityId;
        }

        public float CalculateUtility(IHasDataId ownerContext, IUtilityVariables utilityVariables)
        {
            var value = ValueAccessor.GetValue(ownerContext, utilityVariables);
            var clampedValue = Clamper.Clamp(value);
            return Evaluator.Plot(clampedValue);
        }
    }
}