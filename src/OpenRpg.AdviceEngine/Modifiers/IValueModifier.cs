using OpenRpg.AdviceEngine.Variables;
using OpenRpg.Core.Common;

namespace OpenRpg.AdviceEngine.Modifiers
{
    public interface IValueModifier
    {
        bool ShouldApply(IHasDataId ownerContext, IUtilityVariables utilityVariables);
        float ModifyValue(float currentValue, IHasDataId ownerContext, IUtilityVariables utilityVariables);
    }
}