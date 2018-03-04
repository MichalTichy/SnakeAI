using System;
using System.Collections.Generic;
using System.Drawing;
using SnakeAI;
using SnakeAI.Snake;
using SnakeBase;
using SnakeBase.Snake;
using SnakeBase.World;

namespace UnitTests
{
    public class SnakeMock: ISnake
    {
        public ISnakeHead Head { get; }
        public Direction Heading { get; set; }
        public bool IsAlive { get; }
        public Location HeadPossition { get; set; }
        public ICollection<Location> BodyPossition { get; set; }
        
        public void Born(IWorld world, Location initialLocation)
        {
            throw new NotImplementedException();
        }

        public void Grow()
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }

        public int CalcFitness()
        {
            throw new NotImplementedException();
        }
    }
}