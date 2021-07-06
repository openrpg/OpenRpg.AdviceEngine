using System;
using OpenRpg.AdviceEngine.Variables;
using OpenRpg.Core.Common;

namespace OpenRpg.AdviceEngine.Accessors
{
    public class ManualValueAccessor : IValueAccessor
    {
        public int Id => 0;
        
        public Func<IHasDataId, IUtilityVariables, float> GetValueFunction { get; }

        public ManualValueAccessor(Func<IHasDataId, IUtilityVariables, float> getValueFunction)
        { GetValueFunction = getValueFunction; }

        public float GetValue(IHasDataId context, IUtilityVariables variables) => GetValueFunction(context, variables);
    }
}