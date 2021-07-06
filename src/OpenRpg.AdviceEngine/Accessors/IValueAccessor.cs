using OpenRpg.AdviceEngine.Variables;
using OpenRpg.Core.Common;

namespace OpenRpg.AdviceEngine.Accessors
{
    public interface IValueAccessor : IHasDataId
    {
        float GetValue(IHasDataId ownerContext, IUtilityVariables utilityVariables);
    }
}