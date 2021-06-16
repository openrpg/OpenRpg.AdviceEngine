using OpenRpg.AdviceEngine.Handlers.Advisors;
using OpenRpg.AdviceEngine.Handlers.Considerations;
using OpenRpg.AdviceEngine.Variables;
using OpenRpg.Core.Common;

namespace OpenRpg.AdviceEngine
{
    public class Agent : IAgent
    {
        public IHasDataId OwnerContext { get; }
        public IUtilityVariables UtilityVariables { get; } = new UtilityVariables();
        public IConsiderationHandler ConsiderationHandler { get; }
        public IAdviceHandler AdviceHandler { get; }

        public Agent(IHasDataId ownerContext, IConsiderationHandler handler, IAdviceHandler adviceHandler)
        {
            OwnerContext = ownerContext;
            ConsiderationHandler = handler;
            AdviceHandler = adviceHandler;
            ConsiderationHandler.StartHandler(UtilityVariables);
            AdviceHandler.StartHandler(UtilityVariables);
        }

        public void Dispose()
        {
            ConsiderationHandler.Dispose();
            AdviceHandler.Dispose();
        }
    }
}