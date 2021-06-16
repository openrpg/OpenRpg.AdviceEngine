﻿using System;
using System.Collections.Generic;
using OpenRpg.AdviceEngine.Keys;

namespace OpenRpg.AdviceEngine.Advisors
{
    public class DefaultAdvice : IAdvice
    {
        public int AdviceId { get; }
        public float UtilityValue { get; set; }
        public IEnumerable<UtilityKey> UtilityKeys { get; set; }

        private Func<object> _relatedContextAccessor;

        public DefaultAdvice(int adviceId, IEnumerable<UtilityKey> utilityKeys, Func<object> relatedContextAccessor)
        {
            _relatedContextAccessor = relatedContextAccessor;
            AdviceId = adviceId;
            UtilityKeys = utilityKeys;
        }

        public object GetRelatedContext() => _relatedContextAccessor();
    }
}