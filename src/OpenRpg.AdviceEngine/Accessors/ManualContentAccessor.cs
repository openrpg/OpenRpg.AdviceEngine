using System;
using OpenRpg.AdviceEngine.Variables;
using OpenRpg.Core.Common;

namespace OpenRpg.AdviceEngine.Accessors
{
    public class ManualContextAccessor : IContextAccessor
    {
        public int Id => 0;

        public Func<IHasDataId, IUtilityVariables, object> GetContextFunction { get; }

        public ManualContextAccessor(Func<IHasDataId, IUtilityVariables, object> getContextFunction)
        { GetContextFunction = getContextFunction; }

        public object GetContext(IHasDataId context, IUtilityVariables variables) => GetContextFunction(context, variables);
    }
}