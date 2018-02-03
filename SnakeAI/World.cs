﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;

namespace SnakeAI
{
    public class World : IWorld
    {
        public Size Size { get; set; }

        protected ICollection<ISnake> Snakes { get; set; }
        protected IEnumerable<ISnake> AliveSnakes => Snakes.Where(t => t.IsAlive);
        protected IEnumerable<ISnake> DeathSnakes => Snakes.Where(t => !t.IsAlive);
        public Point FoodPossition { get; protected set; }

        public World(Size size)
        {
            this.Size = size;
            GenerateNextFood();
        }

        protected virtual void PerformGameStep()
        {
            foreach (var snake in Snakes)
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
            FoodPossition = new Point(random.Next(Size.Width), random.Next(Size.Height));
        }
    }
}
