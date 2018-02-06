using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using SnakeBase.Snake;

namespace SnakeBase.World
{
    public class World : IWorld
    {
        public Size Size { get; set; }

        protected ICollection<ISnake> Snakes { get; set; } = new List<ISnake>();
        protected IEnumerable<ISnake> AliveSnakes => Snakes.Where(t => t.IsAlive);
        protected IEnumerable<ISnake> DeathSnakes => Snakes.Where(t => !t.IsAlive);
        public Location FoodPossition { get; protected set; }

        public World(Size size)
        {
            this.Size = size;
            GenerateNextFood();
        }

        public void AddSnakes(ICollection<ISnake> snakes)
        {
            foreach (var snake in snakes)
            {
                Snakes.Add(snake);
            }
        }

        public bool RemoveDeadSnakes()
        {
            foreach (var deathSnake in DeathSnakes)
            {
                Snakes.Remove(deathSnake);
            }

            return !AliveSnakes.Any();
        }

        public virtual void PerformGameStep()
        {
            foreach (var snake in AliveSnakes)
                snake.Move();

            var snakesAtFoodPossition = AliveSnakes.Where(s => s.HeadPossition == FoodPossition).ToList();
            if (snakesAtFoodPossition.Any())
            {
                snakesAtFoodPossition.GetRandom().Grow();
                GenerateNextFood();
            }

        }

        protected void GenerateNextFood()
        {
            var random = new Random();
            FoodPossition = new Location(random.Next(Size.Width), random.Next(Size.Height));
        }
    }
}
