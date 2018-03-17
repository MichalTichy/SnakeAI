using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
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

            Parallel.ForEach(AliveSnakes, snake => snake.Move());
            
            var snakesAtFoodPosition = AliveSnakes.Where(s => s.HeadPossition == FoodPossition).ToList();
            if (snakesAtFoodPosition.Any())
            {
                snakesAtFoodPosition.GetRandom().Grow();
                GenerateNextFood();
            }

        }

        protected void GenerateNextFood()
        {
            var random = new Random();

            Location foodPosition=null;

            var doesFoodCollideWithAnySnake = Snakes.Any(s =>
                s.HeadPossition.Equals(foodPosition) || s.BodyPossition.Any(b => b.Equals(foodPosition)));

            while (foodPosition==null || doesFoodCollideWithAnySnake)
            {
                foodPosition= new Location(random.Next(Size.Width), random.Next(Size.Height));
            }
            FoodPossition = foodPosition;
        }
    }
}
