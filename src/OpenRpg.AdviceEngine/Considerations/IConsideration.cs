using OpenRpg.AdviceEngine.Keys;
using OpenRpg.AdviceEngine.Variables;

namespace OpenRpg.AdviceEngine.Considerations
{
    public interface IConsideration
    {
        UtilityKey UtilityId { get; }
        float CalculateUtility(IUtilityVariables utilityVariables);
    }
}