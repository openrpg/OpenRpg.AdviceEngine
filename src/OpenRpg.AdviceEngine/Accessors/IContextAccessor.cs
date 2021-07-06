using OpenRpg.AdviceEngine.Variables;
using OpenRpg.Core.Common;

namespace OpenRpg.AdviceEngine.Accessors
{
    public interface IContextAccessor : IHasDataId
    {
        IHasDataId Context { get; }
        IUtilityVariables Variables { get; }
        
        object GetContext();
    }
}