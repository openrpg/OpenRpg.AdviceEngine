using OpenRpg.AdviceEngine.Variables;
using OpenRpg.Core.Common;

namespace OpenRpg.AdviceEngine.Accessors
{
    public interface IContextAccessor : IHasDataId
    {
        object GetContext(IHasDataId ownerContext, IUtilityVariables utilityVariables);
    }
}