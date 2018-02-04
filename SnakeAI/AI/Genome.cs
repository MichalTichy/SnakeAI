using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SnakeAI.AI
{
    public class Genome
    {
        public const int GenomeLenght = 192;
        public double[] Genes;

        protected const double MutationChange = 0.01;

        public Genome(double[] genes)
        {
            Genes = genes;
        }

        public Genome()
        {

        }

        protected virtual double[] GenerateRandomGenome()
        {
            var genes = new List<double>();

            for (int i = 0; i < GenomeLenght; i++)
            {
                var num = GenerateRandomGene();

                genes.Add(num);
            }

            return genes.ToArray();
        }

        private static double GenerateRandomGene()
        {
            var random = new Random(DateTime.Now.Millisecond);
            var num = random.NextDouble();
            if (random.Next(2) % 2 == 0)
                num *= -1;
            return num;
        }

        public static Genome operator +(Genome a, Genome b)
        {
            var genes = MergeGenes(a, b);
            Mutate(genes);
            return new Genome(genes);
        }

        private static void Mutate(double[] genes)
        {
            var random = new Random(DateTime.Now.Millisecond);

            for (int i = 0; i < genes.Length; i++)
            {
                if (random.NextDouble() <= MutationChange)
                    genes[i] = GenerateRandomGene();
            }
        }

        private static double[] MergeGenes(Genome a, Genome b)
        {
            List<double> genes = new List<double>();
            const int maxBlockLenght = GenomeLenght / 4;
            int genesLeft = GenomeLenght;
            var random = new Random(DateTime.Now.Millisecond);
            while (genesLeft > 0)
            {
                int blockSize = random.Next(genesLeft) + 1;
                var num = random.NextDouble();
                double[] source;
                if (random.Next(2) % 2 == 0)
                    source = a.Genes;
                else
                    source = b.Genes;

                genes.AddRange(source.Skip(genes.Count).Take(blockSize));
                genesLeft -= blockSize;
            }
            return genes.ToArray();
        }
    }
}
