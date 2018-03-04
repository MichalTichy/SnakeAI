using System;

namespace SnakeAI.AI
{
    public class InputNeuron : INeuron
    {
        protected readonly Func<int?> valueFunc;
        public double Value => GetValue();

        protected virtual double GetValue()
        {
            var value = valueFunc();
            return value ?? 0;
        }

        public InputNeuron(Func<int?> valueFunc)
        {
            this.valueFunc = valueFunc;
        }
        
    }
}