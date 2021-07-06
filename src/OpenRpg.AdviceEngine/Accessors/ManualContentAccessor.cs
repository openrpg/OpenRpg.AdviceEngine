using System;
using OpenRpg.AdviceEngine.Variables;
using OpenRpg.Core.Common;

namespace OpenRpg.AdviceEngine.Accessors
{
    public class ManualContextAccessor : IContextAccessor
    {
        public int Id => 0;

        public IHasDataId Context { get; }
        public IUtilityVariables Variables { get; }
        public Func<IHasDataId, IUtilityVariables, object> GetContextFunction { get; }

        public ManualContextAccessor(IHasDataId context, IUtilityVariables variables,
            Func<IHasDataId, IUtilityVariables, object> getContextFunction)
        {
            Context = context;
            Variables = variables;
            GetContextFunction = getContextFunction;
        }
        
        public object GetContext() => GetContextFunction(Context, Variables);
    }
}