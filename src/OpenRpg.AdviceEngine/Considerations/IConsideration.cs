using OpenRpg.AdviceEngine.Keys;
using OpenRpg.AdviceEngine.Variables;
using OpenRpg.Core.Common;

namespace OpenRpg.AdviceEngine.Considerations
{
    public interface IConsideration
    {
        UtilityKey UtilityId { get; }
        float CalculateUtility(IHasDataId ownerContext, IUtilityVariables utilityVariables);
    }
}