using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SnakeAI.AI
{
    public class Neuron : INeuron
    {
        public double Value => incomingSynapses.Sum(t => t.Value);


        protected ICollection<Synapse> incomingSynapses=new List<Synapse>();

        public Synapse Connect(INeuron target, double modifier)
        {
            var synapse=new Synapse(target,modifier);
            incomingSynapses.Add(synapse);
            return synapse;
        }


    }
}
