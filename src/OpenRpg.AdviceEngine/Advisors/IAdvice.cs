using System.Collections.Generic;
using OpenRpg.AdviceEngine.Accessors;
using OpenRpg.AdviceEngine.Advisors.Modifiers;
using OpenRpg.AdviceEngine.Keys;

namespace OpenRpg.AdviceEngine.Advisors
{
    public interface IAdvice
    {
        int AdviceId { get; }
        float Score { get; set; }
        IEnumerable<UtilityKey> UtilityKeys { get; }
        IEnumerable<IScoreModifier> ScoreModifiers { get; }
        IContextAccessor ContextAccessor { get; }
    }
}