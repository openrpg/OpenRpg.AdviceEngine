using System;
using System.Collections.Generic;
using OpenRpg.AdviceEngine.Advisors;
using OpenRpg.AdviceEngine.Variables;

namespace OpenRpg.AdviceEngine.Handlers.Advisors
{
    public interface IAdviceHandler : IDisposable
    {
        IUtilityVariables UtilityVariables { get; }

        void StartHandler(IUtilityVariables variables);
        void StopHandler();
        
        void AddAdvice(IAdvice advice);
        void RemoveAdvice(IAdvice advice);
        IEnumerable<IAdvice> GetAdvice();
    }
}