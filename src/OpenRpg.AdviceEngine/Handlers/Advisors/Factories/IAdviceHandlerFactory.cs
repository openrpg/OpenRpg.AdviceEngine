using OpenRpg.AdviceEngine.Variables;
using OpenRpg.Core.Common;

namespace OpenRpg.AdviceEngine.Handlers.Advisors.Factories
{
    public interface IAdviceHandlerFactory
    {
        IAdviceHandler Create(IUtilityVariables variables, IHasDataId context);
    }
}