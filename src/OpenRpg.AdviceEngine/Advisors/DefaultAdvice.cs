using System;
using System.Collections.Generic;
using OpenRpg.AdviceEngine.Accessors;
using OpenRpg.AdviceEngine.Advisors.Modifiers;
using OpenRpg.AdviceEngine.Keys;

namespace OpenRpg.AdviceEngine.Advisors
{
    public class DefaultAdvice : IAdvice
    {
        public int AdviceId { get; }
        public float Score { get; set; }
        public IEnumerable<UtilityKey> UtilityKeys { get; }
        public IEnumerable<IScoreModifier> ScoreModifiers { get; }
        public IContextAccessor ContextAccessor { get; }

        public DefaultAdvice(int adviceId, IEnumerable<UtilityKey> utilityKeys, IContextAccessor relatedContextAccessor, IEnumerable<IScoreModifier> scoreModifiers = null)
        {
            ContextAccessor = relatedContextAccessor;
            AdviceId = adviceId;
            UtilityKeys = utilityKeys;
            ScoreModifiers = scoreModifiers ?? Array.Empty<IScoreModifier>();
        }
    }
}