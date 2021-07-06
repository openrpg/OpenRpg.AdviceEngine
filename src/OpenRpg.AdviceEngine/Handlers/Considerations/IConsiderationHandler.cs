using System;
using System.Reactive;
using OpenRpg.AdviceEngine.Considerations;
using OpenRpg.AdviceEngine.Keys;
using OpenRpg.AdviceEngine.Variables;
using OpenRpg.Core.Common;

namespace OpenRpg.AdviceEngine.Handlers.Considerations
{
    public interface IConsiderationHandler : IDisposable
    {
        IUtilityVariables UtilityVariables { get; }
        IHasDataId OwnerContext { get; }

        void StartHandler();
        void StopHandler();
        
        void AddConsideration(IConsideration consideration, IObservable<Unit> explicitUpdateTrigger = null);
        void RemoveConsideration(UtilityKey utilityKey);
        void ClearConsiderations();
    }
}