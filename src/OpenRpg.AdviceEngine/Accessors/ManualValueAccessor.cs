using System;

namespace OpenRpg.AdviceEngine.Accessors
{
    public class ManualValueAccessor : IValueAccessor
    {
        public int Id => 0;
        
        public Func<float> GetValueFunction { get; }

        public ManualValueAccessor(Func<float> getValueFunction)
        {
            GetValueFunction = getValueFunction;
        }

        public float GetValue() => GetValueFunction();
    }
}