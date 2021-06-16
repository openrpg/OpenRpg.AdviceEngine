using System;
using OpenRpg.AdviceEngine.Handlers.Advisors;
using OpenRpg.AdviceEngine.Handlers.Considerations;
using OpenRpg.AdviceEngine.Variables;
using OpenRpg.Core.Common;

namespace OpenRpg.AdviceEngine
{
    public interface IAgent : IDisposable
    {
        IHasDataId RelatedContext { get; }
        IUtilityVariables UtilityVariables { get; }
        IConsiderationHandler ConsiderationHandler { get; }
        IAdviceHandler AdviceHandler { get; }
    }
}