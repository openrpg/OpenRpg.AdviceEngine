using OpenRpg.AdviceEngine.Variables;
using OpenRpg.Core.Common;

namespace OpenRpg.AdviceEngine.Advisors.Modifiers
{
    public interface IScoreModifier
    {
        bool ShouldApply(IHasDataId ownerContext, IUtilityVariables utilityVariables);
        float ModifyScore(float currentScore, IHasDataId ownerContext, IUtilityVariables utilityVariables);
    }
}