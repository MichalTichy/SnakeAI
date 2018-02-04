namespace SnakeAI.AI
{
    public class InputNeuron : INeuron
    {
        public double Value { get; protected set; }

        public virtual void Setvalue(float value)
        {
            Value = value;
        }
    }
}