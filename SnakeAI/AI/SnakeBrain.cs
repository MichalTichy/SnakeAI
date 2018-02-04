using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SnakeAI.AI
{
    public class SnakeBrain : Brain
    {
        private readonly SnakeDistanceSence distanceSence;
        
        protected override int InputNeuronsCount => 12;
        protected override int HiddenNeuronsCount => 12;
        protected override int OutputNeuronsCount => 4;

        protected INeuron UpNeuron { get; set; }
        protected INeuron DownNeuron { get; set; }
        protected INeuron LeftNeuron { get; set; }
        protected INeuron RightNeuron { get; set; }

        public SnakeBrain(Genome genome,SnakeDistanceSence distanceSence)
        {
            this.distanceSence = distanceSence;

            var outputs = BuildNeuronNetwork(genome, distanceSence.InputFunctions);

            UpNeuron = outputs.ElementAt(0);
            DownNeuron = outputs.ElementAt(1);
            RightNeuron = outputs.ElementAt(2);
            LeftNeuron = outputs.ElementAt(3);
        }

        public override Direction DetermineNextMove()
        {
            var UpNeuronValue = UpNeuron.Value;
            var DownNeuronValue = DownNeuron.Value;
            var RightNeuronValue = RightNeuron.Value;
            var LeftNeuronValue = LeftNeuron.Value;

            var values = new[] {UpNeuronValue, DownNeuronValue, RightNeuronValue, LeftNeuronValue};

            var max = values.OrderBy(t => t).Last();

            if (Math.Abs(UpNeuronValue - max) < 0.000000001)
                return Direction.Up;
            if (Math.Abs(DownNeuronValue - max) < 0.000000001)
                return Direction.Down;
            if (Math.Abs(RightNeuronValue - max) < 0.000000001)
                return Direction.Right;
            if (Math.Abs(LeftNeuronValue - max) < 0.000000001)
                return Direction.Left;

            throw new Exception("Unable to determine next move");
        }
    }

    public abstract class Brain : IBrain
    {
        protected abstract int InputNeuronsCount { get; }
        protected abstract int HiddenNeuronsCount { get; }
        protected abstract int OutputNeuronsCount { get; }

        protected ICollection<Neuron> BuildNeuronNetwork(Genome genome,ICollection<Func<int?>> inputFuncs)
        {
            var totalSynapsesCount = InputNeuronsCount * HiddenNeuronsCount + HiddenNeuronsCount * OutputNeuronsCount;
            if (genome.Genes.Length != totalSynapsesCount)
                throw new Exception($"Genome have invalid size. Expected {totalSynapsesCount} | Got {genome.Genes.Length}");

            if (inputFuncs.Count != InputNeuronsCount)
                throw new Exception(
                    $"Count of input functions is invalid. Expected {InputNeuronsCount} | Got {inputFuncs.Count}");

            var inputs=new List<InputNeuron>();
            var outputs=new List<Neuron>();
            var hiddenNeurons=new List<Neuron>();

            var currentGene = 0;
            var currentInputFunc = 0;

            for (int i = 0; i < InputNeuronsCount; i++)
            {
                inputs.Add(new InputNeuron(inputFuncs.ElementAt(currentInputFunc++)));
            }

            for (int i = 0; i < HiddenNeuronsCount; i++)
            {
                var neuron=new Neuron();
                hiddenNeurons.Add(neuron);
                foreach (var input in inputs)
                    neuron.Connect(input, genome.Genes[currentGene++]);
            }

            for (int i = 0; i < OutputNeuronsCount; i++)
            {
                var newNeuron=new Neuron();
                outputs.Add(new Neuron());
                foreach (var neuron in hiddenNeurons)
                    newNeuron.Connect(neuron, genome.Genes[currentGene++]);
            }

            return outputs;
        }

        public abstract Direction DetermineNextMove();




    }
}
