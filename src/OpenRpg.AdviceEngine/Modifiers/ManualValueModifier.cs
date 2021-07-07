using System;
using OpenRpg.AdviceEngine.Variables;
using OpenRpg.Core.Common;

namespace OpenRpg.AdviceEngine.Modifiers
{
    public class ManualValueModifier : IValueModifier
    {
        private readonly Func<IHasDataId, IUtilityVariables, bool> _shouldApplyFunction;
        private readonly Func<float, IHasDataId, IUtilityVariables, float> _modifyScoreFunction;

        public ManualValueModifier(Func<IHasDataId, IUtilityVariables, bool> shouldApplyFunction, Func<float, IHasDataId, IUtilityVariables, float> modifyScoreFunction)
        {
            _modifyScoreFunction = modifyScoreFunction;
            _shouldApplyFunction = shouldApplyFunction;
        }

        public bool ShouldApply(IHasDataId ownerContext, IUtilityVariables utilityVariables) => 
            _shouldApplyFunction(ownerContext, utilityVariables);

        public float ModifyValue(float currentScore, IHasDataId ownerContext, IUtilityVariables utilityVariables) =>
            _modifyScoreFunction(currentScore, ownerContext, utilityVariables);
    }
}