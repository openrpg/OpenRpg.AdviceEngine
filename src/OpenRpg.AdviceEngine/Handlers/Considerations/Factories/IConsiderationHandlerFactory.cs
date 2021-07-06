using OpenRpg.AdviceEngine.Variables;
using OpenRpg.Core.Common;

namespace OpenRpg.AdviceEngine.Handlers.Considerations.Factories
{
    public interface IConsiderationHandlerFactory
    {
        IConsiderationHandler Create(IUtilityVariables variables, IHasDataId context);
    }
}