using System.Collections.Generic;
using OpenRpg.AdviceEngine.Keys;

namespace OpenRpg.AdviceEngine.Advisors
{
    public interface IAdvice
    {
        int AdviceId { get; }
        float UtilityValue { get; set; }
        IEnumerable<UtilityKey> UtilityKeys { get; }
        object GetRelatedContext();
    }
}