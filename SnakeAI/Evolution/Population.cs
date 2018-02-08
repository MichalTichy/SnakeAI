using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using SnakeAI.Snake;
using SnakeBase;
using SnakeBase.Snake;
using SnakeBase.World;

namespace SnakeAI.Evolution
{
    public class Population
    {
        private readonly int populationSize;
        public IWorld world { get; protected set; }
        protected List<SmartSnake> _snakes { get; set; } = new List<SmartSnake>();
        public IReadOnlyCollection<SmartSnake> Snakes => _snakes.AsReadOnly();

        public Population(int populationSize,Size worldSize)
        {
            this.populationSize = populationSize;
            this.world = new World(worldSize);
            for (int i = 0; i < populationSize; i++)
            {
                _snakes.Add(new SmartSnake(GenerateInitialLocation(),world));
            }
        }

        public Population(List<SmartSnake> snakes, Size worldSize)
        {
            this._snakes = snakes;
            this.populationSize = snakes.Count;
            this.world=new World(worldSize);
        }

        public Population Evolve()
        {
            var snakes=new List<SmartSnake>();

            var selectedSnakes = Selection();

            var newSnakes = Crossover(selectedSnakes);

            return new Population(snakes,world.Size);
        }

        protected virtual ICollection<SmartSnake> Selection()
        {
            var result=new List<SmartSnake>();

            var source=new List<SmartSnake>();
            foreach (var snake in Snakes)
            {
                for (int i = 0; i < CalcFitness(snake); i++)
                {
                    source.Add(snake);
                }
            }

            var random=new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < populationSize/2; i++)
            {
                result.Add(source.ElementAt(random.Next(source.Count)));
            }
            
            return result;
        }

        protected virtual ICollection<SmartSnake> Crossover(ICollection<SmartSnake> snakes)
        {
            var result=new List<SmartSnake>();

            var random=new Random(DateTime.Now.Millisecond);
            while (result.Count < populationSize)
            {
                var parent1 = snakes.ElementAt(random.Next(snakes.Count));
                var parent2 = snakes.ElementAt(random.Next(snakes.Count));
                var newGenome = parent1.Genome + parent2.Genome;
                result.Add(new SmartSnake(GenerateInitialLocation(),world,newGenome));
            }

            return result;
        }

        protected virtual int CalcFitness(ISnake snake)
        {
            return 1 + snake.BodyPossition.Count;
        }

        protected Location GenerateInitialLocation()
        {
            var random = new Random();
            return new Location(random.Next(world.Size.Width), random.Next(world.Size.Height));
        }
    }
}
