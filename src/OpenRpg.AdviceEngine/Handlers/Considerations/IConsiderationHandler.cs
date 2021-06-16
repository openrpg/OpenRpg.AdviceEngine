using System;
using System.Reactive;
using OpenRpg.AdviceEngine.Considerations;
using OpenRpg.AdviceEngine.Keys;
using OpenRpg.AdviceEngine.Variables;

namespace OpenRpg.AdviceEngine.Handlers.Considerations
{
    public interface IConsiderationHandler : IDisposable
    {
        IUtilityVariables UtilityVariables { get; }

        void StartHandler(IUtilityVariables variables);
        void StopHandler();
        
        void AddConsideration(IConsideration consideration, IObservable<Unit> explicitUpdateTrigger = null);
        void RemoveConsideration(UtilityKey utilityKey);
    }
}