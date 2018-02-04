namespace SnakeAI.AI
{
    public class Synapse
    {
        public double Modifier { get; set; }

        public INeuron Source { get; protected set; }

        public double Value => Source.Value* Modifier;

        public Synapse(INeuron source,double modifier)
        {
            Source = source;
            Modifier = modifier;
        }
    }
}